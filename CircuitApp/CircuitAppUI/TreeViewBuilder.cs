using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI
{
    /// <summary>
    /// Service class for work with elementsTreeView 
    /// </summary>
    public static class TreeViewBuilder
    {
        //TODO: мне кажется, работу с нодами надо вынести в отдельный класс. В главной форме слишком много логики. Либо бить окно на контролы (done)
        /// <summary>
        /// Check if first node contains second node
        /// </summary>
        /// <param name="node1">Outer</param>
        /// <param name="node2">Inner</param>
        /// <returns>True if node1 contains node2</returns>
        public static bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null)
            {
                return false;
            }

            if (node2.Parent.Equals(node1))
            {
                return true;
            }

            return ContainsNode(node1, node2.Parent);
        }

        /// <summary>
        /// Combines dragged node and target node in new segment
        /// </summary>
        /// <param name="targetNode">Target node</param>
        /// <param name="draggedNode">Dragged node</param>
        /// <param name="draggedNodeParent">Dragged node parent</param>
        /// <param name="targetNodeParent">Target node parent</param>
        public static void MoveToElement(TreeNode targetNode, TreeNode draggedNode,
            TreeNode draggedNodeParent, TreeNode targetNodeParent)
        {
            //TODO: var (done)
            var form = new ConnectionTypeForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                form.Type.SubSegments.Add(targetNode.Tag as ISegment);
                form.Type.SubSegments.Add(draggedNode.Tag as ISegment);
                (targetNodeParent.Tag as ISegment)?.SubSegments.Add(form.Type);
                (draggedNodeParent.Tag as Segment)?.SubSegments.Remove(draggedNode.Tag as ISegment);
                (targetNodeParent.Tag as ISegment)?.SubSegments.Remove(targetNode.Tag as ISegment);
                //TODO: здоровенный кусок кода дублируется только потому, что в качестве корня дерева используется не ISegment (done)
            }
        }

        /// <summary>
        /// Populates tree with elements
        /// </summary>
        /// <param name="currentNode">Tree root node</param>
        /// <param name="subSegments">Collection to add</param>
        public static void PopulateTree(TreeNode currentNode, EventDrivenCollection subSegments)
        {
            foreach (var segment in subSegments)
            {
                DefineTreeNode(currentNode, segment);
            }
        }

        //TODO: DefineTreeNode() (done)?
        /// <summary>
        /// Create new node, fill it's name and tag with segment value and put it in appropriate position in treeview
        /// </summary>
        /// <param name="currentNode">Root note for branch</param>
        /// <param name="segment">Segment to add</param>
        private static void DefineTreeNode(TreeNode currentNode, ISegment segment)
        {
            //TODO: Если у цепей сделать дефолтное имя, то от свитча можно будет избавиться (done)
            var node = new TreeNode
            {
                Text = segment.Name,
                Tag = segment
            };
            currentNode.Nodes.Add(node);
            if (segment.SubSegments != null)
            {
                foreach (var s in segment.SubSegments)
                {
                    DefineTreeNode(currentNode.LastNode, s);
                }
            }
        }

        /// <summary>
        /// Finds path to current node and gets object from tag
        /// </summary>
        /// <param name="currentNode">Node to find path to</param>
        /// <param name="currentSegment">Circuit segment that contains element from currentNode.Tag</param>
        /// <returns>Path to currentNode and segment/element from it's tag</returns>
        private static (List<int>, ISegment) FindPath(TreeNode currentNode,
            EventDrivenCollection currentSegment)
        {
            var path = new List<int>();
            while (currentNode.Parent != null)
            {
                path.Insert(0, currentNode.Index);
                currentNode = currentNode.Parent;
            }

            ISegment segment = currentSegment[path[0]];

            foreach (var index in path.Skip(1))
            {
                segment = segment.SubSegments[index];
            }

            return (path, segment);
        }

        /// <summary>
        /// Replaces element int circuit
        /// </summary>
        /// <param name="currentNode">Node that contains element to be replaced</param>
        /// <param name="currentSegment">Segment that contains element to be replaced</param>
        /// <param name="replace">Replacement segment</param>
        /// <returns>Returns path to replacement position</returns>
        public static List<int> ReplaceElement(TreeNode currentNode, EventDrivenCollection currentSegment,
            ISegment replace)
        {
            var replaceNode = currentNode;
            var pathAndItem = FindPath(currentNode, currentSegment);

            SegmentRemove(currentSegment, pathAndItem.Item2);

            int replaceIndex = pathAndItem.Item1[pathAndItem.Item1.Count - 1];

            if (replaceNode.Parent.Parent != null)
            {
                pathAndItem.Item1.RemoveAt(pathAndItem.Item1.Count - 1);
                pathAndItem.Item2 = currentSegment[pathAndItem.Item1[0]];
                foreach (var index in pathAndItem.Item1.Skip(1))
                {
                    pathAndItem.Item2 = pathAndItem.Item2.SubSegments[index];
                }
                pathAndItem.Item2.SubSegments.Insert(replaceIndex, replace);
                pathAndItem.Item1.Add(replaceIndex);
                return pathAndItem.Item1;
            }
            currentSegment.Insert(replaceIndex, replace);
            return pathAndItem.Item1;
        }

        /// <summary>
        /// Removes segment from segment collection
        /// </summary>
        /// <param name="subSegments">Collection to remove from</param>
        /// <param name="toDelete">Segment to be removed</param>
        public static void SegmentRemove(EventDrivenCollection subSegments, ISegment toDelete)
        {
            if (subSegments == null)
            {
                return;
            }
            bool isDeleted = subSegments.Remove(toDelete);
            if (!isDeleted)
            {
                foreach (var segment in subSegments)
                {
                    SegmentRemove(segment.SubSegments, toDelete);
                }
            }
        }
    }
}

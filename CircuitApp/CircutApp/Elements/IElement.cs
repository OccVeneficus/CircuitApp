using CircutApp.Segments;

namespace CircutApp.Elements
{
    /// <summary>
    /// Interface for electric circuit elements
    /// </summary>
    public interface IElement : ISegment
    {
        /// <summary>
        /// Element value
        /// </summary>
        double Value { get; set; }
        /// <summary>
        /// Element name
        /// </summary>
        new string Name { get; set; }
    }
}

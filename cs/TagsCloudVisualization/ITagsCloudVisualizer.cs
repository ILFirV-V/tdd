using System.Drawing;
using System.Drawing.Imaging;

namespace TagsCloudVisualization;

public interface ITagsCloudVisualizer
{
    public void VisualizeLayoutRectangles(IList<Rectangle> rectangles);
    public void Save(string outputFilePath, ImageFormat imageFormat);
}
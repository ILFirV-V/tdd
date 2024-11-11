using System.Drawing;

namespace TagsCloudVisualization;

public interface ICircularCloudLayouter
{
    public Rectangle PutNextRectangle(Size rectangleSize);
}
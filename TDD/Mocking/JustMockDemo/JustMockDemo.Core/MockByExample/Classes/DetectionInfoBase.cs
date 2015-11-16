namespace JustMockDemo.Core.MockByExample.Classes
{
    public class DetectionInfoBase : IDetectionInfoBase
    {
        public string Name { get; set; }
    }
  
    public interface IDetectionInfoBase
    {
        string Name { get; set; }
    }
}
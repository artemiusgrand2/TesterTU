
namespace TesterTU.Interfaces
{
    public interface IControllerDataStream
    {
        bool Read(out byte[] data, int lengtData);

        int Write(byte[] data);

        void Dispose();
    }
}

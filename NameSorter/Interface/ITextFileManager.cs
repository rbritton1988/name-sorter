
namespace NameSorter.Interface
{
    interface ITextFileManager
    {
        string[] ReadIn(string filePath);
        void WriteOut(string filePath, string[] content);
    }
}

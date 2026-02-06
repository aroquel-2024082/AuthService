using AuthServiceIN6BM.Application.Interfaces;

namespace AuthServiceIN6BM.Api.Models;

public class FormFileAdapter : IFileData
{
    private readonly IFormFile _formFile;
    private byte[]? _data;
    public FormFileAdapter(IFormFile formFile)
    {
        // Corregir error
        ArgumentNullException.ThrowIfNull(formFile);

        if (formFile.Length == 0)
        {
            throw new ArgumentException("El archivo está vacío", nameof(formFile));
        }
        //

        _formFile = formFile;
    }

    public byte[] Data
    {
        get
        {
            if(_data == null)
            {
                using var memoryStream = new MemoryStream();
                _formFile.CopyTo(memoryStream);
                _data = memoryStream.ToArray();
            }
            return _data;
        }
    }

    public string ContentType => _formFile.ContentType;
    public string FileName => _formFile.FileName;
    public long Size => _formFile.Length;
}
using System.IO;

public class LXYDRC4FileStream : FileStream
{
    protected LXYDRC4 rc4;
 
    public LXYDRC4FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) : base(path, mode, access, share, bufferSize, useAsync)
    {
        InitRC4();
    }

    public LXYDRC4FileStream(string path, FileMode mode) : base(path, mode)
    {
        InitRC4();
    }

    public LXYDRC4FileStream(string path, FileMode mode, FileAccess access) : base(path, mode, access)
    {
        InitRC4();
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        var index =  base.Read(buffer, offset, count);
        rc4.ToRC4(ref buffer, offset, count);
        return index;
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        rc4.ToRC4(ref buffer, offset, count);
        base.Write(buffer, offset, count);
    }

    protected void InitRC4()
    {
        rc4 = new LXYDRC4();
    }
}
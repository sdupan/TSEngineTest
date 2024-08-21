using System.Linq;
using System.Text;

public class LXYDRC4
{
    protected string rc4Key = "bj4Mr#@e!62GMedHye!ait^2EUUdSgI7";
    protected byte[] rc4KeyBox;
    protected int bx = 0;
    protected int by = 0;

    public LXYDRC4()
    {
        GetRC4Key();
    }

    public void ToRC4(ref byte[] buffer, int offset, int count)
    {
        byte swapByte = 0;
        var num = System.Math.Min(offset + count, buffer.Length);
        for (int i = offset; i < num; i++)
        {
            bx = (bx + 1) % 256;
            by = (rc4KeyBox[bx] + by) % 256;
            swapByte = rc4KeyBox[bx];
            rc4KeyBox[bx] = rc4KeyBox[by];
            rc4KeyBox[by] = swapByte;
            buffer[i] = (byte)(buffer[i] ^ rc4KeyBox[(rc4KeyBox[bx] + rc4KeyBox[by]) % 256]);
        }
    }

    protected byte[] GetRC4Key()
    {
        if (rc4KeyBox == null)
        {
            var keys = Encoding.UTF8.GetBytes(rc4Key);
            rc4KeyBox = Enumerable.Range(0, 256).Select(i => (byte)i).ToArray();
            for (int i = 0, j = 0; i < 256; i++)
            {
                j = (keys[i % keys.Length] + rc4KeyBox[i] + j) % 256;
                byte swapByte = rc4KeyBox[i];
                rc4KeyBox[i] = rc4KeyBox[j];
                rc4KeyBox[j] = swapByte;
            }
        }

        return rc4KeyBox;
    }
}
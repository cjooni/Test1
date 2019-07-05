using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    class CMarshal
    {
        // 받은 패킷 바이트를 구조체화함
        public void SetBuffer(byte[] pbyte)
        {
            unsafe	// c#에서는 포인터연산을 통한 메모리복사를 안전하지 않는 코드로 판단, unsafe블록안에 감싸줘야함
            {
                fixed (byte* fixed_buffer = pbyte)
                {
                    Marshal.PtrToStructure((IntPtr)fixed_buffer, this);
                }
            }
        }

        // 보낼패킷 구조체를 byte에 복사함
        public void PutBuffer(byte[] pbyte)
        {
            int mycount = Marshal.SizeOf(this);
            unsafe
            {
                fixed (byte* fixed_buffer = pbyte)
                {
                    Marshal.StructureToPtr(this, (IntPtr)fixed_buffer, true);

                    for (int i = 0; i < mycount; i++)
                    {
                        pbyte[i] = fixed_buffer[i];

                    }
                }
            }

        }

        public int GetSize()
        {
            return Marshal.SizeOf(this);
        }

        public byte[] GetBuffer()
        {
            byte[] rvalue = new byte[GetSize()];
            PutBuffer(rvalue);
            return rvalue;
        }

    }
}

using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	internal struct CreateDeviceIdOptionsInternal : ISettable<CreateDeviceIdOptions>, IDisposable
	{
		// Token: 0x17000B67 RID: 2919
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B67")]
		public Utf8String DeviceModel
		{
			[Token(Token = "0x6002751")]
			[Address(RVA = "0x558930", Offset = "0x556F30", VA = "0x180558930")]
			set
			{
			}
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x558830", Offset = "0x556E30", VA = "0x180558830", Slot = "4")]
		public void Set(ref CreateDeviceIdOptions other)
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x558890", Offset = "0x556E90", VA = "0x180558890", Slot = "5")]
		public void Set(ref CreateDeviceIdOptions? other)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x5587E0", Offset = "0x556DE0", VA = "0x1805587E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_DeviceModel;
	}
}

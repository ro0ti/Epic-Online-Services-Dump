using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x0200069D RID: 1693
	[Token(Token = "0x200069D")]
	internal struct EndSessionOptionsInternal : ISettable<EndSessionOptions>, IDisposable
	{
		// Token: 0x06002B95 RID: 11157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref EndSessionOptions other)
		{
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B96")]
		[Address(RVA = "0x570360", Offset = "0x56E960", VA = "0x180570360", Slot = "5")]
		public void Set(ref EndSessionOptions? other)
		{
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012EA RID: 4842
		[Token(Token = "0x40012EA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}

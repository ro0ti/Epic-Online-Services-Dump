using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	internal struct UninstallModOptionsInternal : ISettable<UninstallModOptions>, IDisposable
	{
		// Token: 0x17000690 RID: 1680
		// (set) Token: 0x060017E8 RID: 6120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000690")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x520870", Offset = "0x51EE70", VA = "0x180520870")]
			set
			{
			}
		}

		// Token: 0x17000691 RID: 1681
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000691")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x60017E9")]
			[Address(RVA = "0x5208D0", Offset = "0x51EED0", VA = "0x1805208D0")]
			set
			{
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x520630", Offset = "0x51EC30", VA = "0x180520630", Slot = "4")]
		public void Set(ref UninstallModOptions other)
		{
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x520720", Offset = "0x51ED20", VA = "0x180520720", Slot = "5")]
		public void Set(ref UninstallModOptions? other)
		{
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x5205D0", Offset = "0x51EBD0", VA = "0x1805205D0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Mod;
	}
}

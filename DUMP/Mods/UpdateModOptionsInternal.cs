using System;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000380 RID: 896
	[Token(Token = "0x2000380")]
	internal struct UpdateModOptionsInternal : ISettable<UpdateModOptions>, IDisposable
	{
		// Token: 0x1700069D RID: 1693
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700069D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x521390", Offset = "0x51F990", VA = "0x180521390")]
			set
			{
			}
		}

		// Token: 0x1700069E RID: 1694
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700069E")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x6001809")]
			[Address(RVA = "0x5213F0", Offset = "0x51F9F0", VA = "0x1805213F0")]
			set
			{
			}
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x521150", Offset = "0x51F750", VA = "0x180521150", Slot = "4")]
		public void Set(ref UpdateModOptions other)
		{
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x521240", Offset = "0x51F840", VA = "0x180521240", Slot = "5")]
		public void Set(ref UpdateModOptions? other)
		{
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x5210F0", Offset = "0x51F6F0", VA = "0x1805210F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Mod;
	}
}

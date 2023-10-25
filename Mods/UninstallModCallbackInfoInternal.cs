using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	internal struct UninstallModCallbackInfoInternal : ICallbackInfoInternal, IGettable<UninstallModCallbackInfo>, ISettable<UninstallModCallbackInfo>, IDisposable
	{
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00006BE4 File Offset: 0x00004DE4
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000689")]
		public Result ResultCode
		{
			[Token(Token = "0x60017D7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60017D8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700068A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60017D9")]
			[Address(RVA = "0x520220", Offset = "0x51E820", VA = "0x180520220")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017DA")]
			[Address(RVA = "0x520380", Offset = "0x51E980", VA = "0x180520380")]
			set
			{
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700068B")]
		public object ClientData
		{
			[Token(Token = "0x60017DB")]
			[Address(RVA = "0x5201B0", Offset = "0x51E7B0", VA = "0x1805201B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017DC")]
			[Address(RVA = "0x520320", Offset = "0x51E920", VA = "0x180520320")]
			set
			{
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00006BFC File Offset: 0x00004DFC
		[Token(Token = "0x1700068C")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60017DD")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00006C14 File Offset: 0x00004E14
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700068D")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x60017DE")]
			[Address(RVA = "0x5202A0", Offset = "0x51E8A0", VA = "0x1805202A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017DF")]
			[Address(RVA = "0x5203E0", Offset = "0x51E9E0", VA = "0x1805203E0")]
			set
			{
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x51FEC0", Offset = "0x51E4C0", VA = "0x18051FEC0", Slot = "6")]
		public void Set(ref UninstallModCallbackInfo other)
		{
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x51FFF0", Offset = "0x51E5F0", VA = "0x18051FFF0", Slot = "7")]
		public void Set(ref UninstallModCallbackInfo? other)
		{
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x51FE20", Offset = "0x51E420", VA = "0x18051FE20", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x51FE90", Offset = "0x51E490", VA = "0x18051FE90", Slot = "5")]
		public void Get(out UninstallModCallbackInfo output)
		{
		}

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ClientData;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Mod;
	}
}

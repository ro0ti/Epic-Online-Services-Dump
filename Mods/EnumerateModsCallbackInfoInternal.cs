using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000364 RID: 868
	[Token(Token = "0x2000364")]
	internal struct EnumerateModsCallbackInfoInternal : ICallbackInfoInternal, IGettable<EnumerateModsCallbackInfo>, ISettable<EnumerateModsCallbackInfo>, IDisposable
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00006A34 File Offset: 0x00004C34
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700065F")]
		public Result ResultCode
		{
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001744")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000660")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001745")]
			[Address(RVA = "0x50B4B0", Offset = "0x509AB0", VA = "0x18050B4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001746")]
			[Address(RVA = "0x50B590", Offset = "0x509B90", VA = "0x18050B590")]
			set
			{
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000661")]
		public object ClientData
		{
			[Token(Token = "0x6001747")]
			[Address(RVA = "0x50B440", Offset = "0x509A40", VA = "0x18050B440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001748")]
			[Address(RVA = "0x50B530", Offset = "0x509B30", VA = "0x18050B530")]
			set
			{
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Token(Token = "0x17000662")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001749")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00006A64 File Offset: 0x00004C64
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000663")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x600174A")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return ModEnumerationType.Installed;
			}
			[Token(Token = "0x600174B")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174C")]
		[Address(RVA = "0x50B230", Offset = "0x509830", VA = "0x18050B230", Slot = "6")]
		public void Set(ref EnumerateModsCallbackInfo other)
		{
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x50B300", Offset = "0x509900", VA = "0x18050B300", Slot = "7")]
		public void Set(ref EnumerateModsCallbackInfo? other)
		{
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x50B1B0", Offset = "0x5097B0", VA = "0x18050B1B0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x50B210", Offset = "0x509810", VA = "0x18050B210", Slot = "5")]
		public void Get(out EnumerateModsCallbackInfo output)
		{
		}

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ClientData;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x18")]
		private ModEnumerationType m_Type;
	}
}

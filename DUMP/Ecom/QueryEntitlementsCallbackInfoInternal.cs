using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	internal struct QueryEntitlementsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryEntitlementsCallbackInfo>, ISettable<QueryEntitlementsCallbackInfo>, IDisposable
	{
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x000096D4 File Offset: 0x000078D4
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A60")]
		public Result ResultCode
		{
			[Token(Token = "0x60023F4")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60023F5")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A61")]
		public object ClientData
		{
			[Token(Token = "0x60023F6")]
			[Address(RVA = "0x54BB90", Offset = "0x54A190", VA = "0x18054BB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F7")]
			[Address(RVA = "0x54BC80", Offset = "0x54A280", VA = "0x18054BC80")]
			set
			{
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000096EC File Offset: 0x000078EC
		[Token(Token = "0x17000A62")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60023F8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A63")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60023F9")]
			[Address(RVA = "0x54BC00", Offset = "0x54A200", VA = "0x18054BC00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023FA")]
			[Address(RVA = "0x54BCE0", Offset = "0x54A2E0", VA = "0x18054BCE0")]
			set
			{
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x54BAD0", Offset = "0x54A0D0", VA = "0x18054BAD0", Slot = "6")]
		public void Set(ref QueryEntitlementsCallbackInfo other)
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x54B9B0", Offset = "0x549FB0", VA = "0x18054B9B0", Slot = "7")]
		public void Set(ref QueryEntitlementsCallbackInfo? other)
		{
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x54B930", Offset = "0x549F30", VA = "0x18054B930", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x54B990", Offset = "0x549F90", VA = "0x18054B990", Slot = "5")]
		public void Get(out QueryEntitlementsCallbackInfo output)
		{
		}

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}

using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	internal struct UpdateModCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateModCallbackInfo>, ISettable<UpdateModCallbackInfo>, IDisposable
	{
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00006C8C File Offset: 0x00004E8C
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000696")]
		public Result ResultCode
		{
			[Token(Token = "0x60017F7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60017F8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000697")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60017F9")]
			[Address(RVA = "0x520D40", Offset = "0x51F340", VA = "0x180520D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FA")]
			[Address(RVA = "0x520EA0", Offset = "0x51F4A0", VA = "0x180520EA0")]
			set
			{
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000698")]
		public object ClientData
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x520CD0", Offset = "0x51F2D0", VA = "0x180520CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FC")]
			[Address(RVA = "0x520E40", Offset = "0x51F440", VA = "0x180520E40")]
			set
			{
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[Token(Token = "0x17000699")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60017FD")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00006CBC File Offset: 0x00004EBC
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700069A")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x520DC0", Offset = "0x51F3C0", VA = "0x180520DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x520F00", Offset = "0x51F500", VA = "0x180520F00")]
			set
			{
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001800")]
		[Address(RVA = "0x5209E0", Offset = "0x51EFE0", VA = "0x1805209E0", Slot = "6")]
		public void Set(ref UpdateModCallbackInfo other)
		{
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x520B10", Offset = "0x51F110", VA = "0x180520B10", Slot = "7")]
		public void Set(ref UpdateModCallbackInfo? other)
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x520940", Offset = "0x51EF40", VA = "0x180520940", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x5209B0", Offset = "0x51EFB0", VA = "0x1805209B0", Slot = "5")]
		public void Get(out UpdateModCallbackInfo output)
		{
		}

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ClientData;

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Mod;
	}
}

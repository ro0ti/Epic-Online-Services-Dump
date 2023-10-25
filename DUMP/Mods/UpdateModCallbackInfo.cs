using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public struct UpdateModCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00006C44 File Offset: 0x00004E44
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000692")]
		public Result ResultCode
		{
			[Token(Token = "0x60017ED")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60017EE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000693")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60017EF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017F0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000694")]
		public object ClientData
		{
			[Token(Token = "0x60017F1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017F2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00006C5C File Offset: 0x00004E5C
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000695")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x60017F3")]
			[Address(RVA = "0x50D620", Offset = "0x50BC20", VA = "0x18050D620")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017F4")]
			[Address(RVA = "0x50D640", Offset = "0x50BC40", VA = "0x18050D640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00006C74 File Offset: 0x00004E74
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x520F70", Offset = "0x51F570", VA = "0x180520F70", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x520FC0", Offset = "0x51F5C0", VA = "0x180520FC0")]
		internal void Set(ref UpdateModCallbackInfoInternal other)
		{
		}
	}
}

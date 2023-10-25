using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public struct ShowNativeProfileCallbackInfo : ICallbackInfo
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00002DA4 File Offset: 0x00000FA4
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F2")]
		public Result ResultCode
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F3")]
		public object ClientData
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F4")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F5")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x4B0D80", Offset = "0x4AF380", VA = "0x1804B0D80", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x4B0DD0", Offset = "0x4AF3D0", VA = "0x1804B0DD0")]
		internal void Set(ref ShowNativeProfileCallbackInfoInternal other)
		{
		}
	}
}

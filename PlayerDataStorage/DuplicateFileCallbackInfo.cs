using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	public struct DuplicateFileCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00005BF4 File Offset: 0x00003DF4
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700054B")]
		public Result ResultCode
		{
			[Token(Token = "0x60013EE")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60013EF")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700054C")]
		public object ClientData
		{
			[Token(Token = "0x60013F0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013F1")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700054D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013F2")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013F3")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x4F0A60", Offset = "0x4EF060", VA = "0x1804F0A60", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x4F0AB0", Offset = "0x4EF0B0", VA = "0x1804F0AB0")]
		internal void Set(ref DuplicateFileCallbackInfoInternal other)
		{
		}
	}
}

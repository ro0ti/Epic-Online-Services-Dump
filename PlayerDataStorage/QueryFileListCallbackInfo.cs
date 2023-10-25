using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	public struct QueryFileListCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00005EAC File Offset: 0x000040AC
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000576")]
		public Result ResultCode
		{
			[Token(Token = "0x60014C6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60014C7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000577")]
		public object ClientData
		{
			[Token(Token = "0x60014C8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60014C9")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000578")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014CA")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60014CB")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x00005EC4 File Offset: 0x000040C4
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000579")]
		public uint FileCount
		{
			[Token(Token = "0x60014CC")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60014CD")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00005EDC File Offset: 0x000040DC
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x4FDBE0", Offset = "0x4FC1E0", VA = "0x1804FDBE0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x4FDC30", Offset = "0x4FC230", VA = "0x1804FDC30")]
		internal void Set(ref QueryFileListCallbackInfoInternal other)
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	public struct SendRequestToJoinCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x00009DF4 File Offset: 0x00007FF4
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B3B")]
		public Result ResultCode
		{
			[Token(Token = "0x60026B4")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60026B5")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026B7 RID: 9911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B3C")]
		public object ClientData
		{
			[Token(Token = "0x60026B6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026B7")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026B9 RID: 9913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B3D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60026B8")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026B9")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026BB RID: 9915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B3E")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60026BA")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026BB")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00009E0C File Offset: 0x0000800C
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x567FB0", Offset = "0x5665B0", VA = "0x180567FB0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x568000", Offset = "0x566600", VA = "0x180568000")]
		internal void Set(ref SendRequestToJoinCallbackInfoInternal other)
		{
		}
	}
}

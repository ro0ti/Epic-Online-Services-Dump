using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	public struct UpdateReceivingVolumeCallbackInfo : ICallbackInfo
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C4")]
		public Result ResultCode
		{
			[Token(Token = "0x6000F73")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000F74")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C5")]
		public object ClientData
		{
			[Token(Token = "0x6000F75")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F76")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C6")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F77")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F78")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C7")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00004F4C File Offset: 0x0000314C
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C8")]
		public float Volume
		{
			[Token(Token = "0x6000F7B")]
			[Address(RVA = "0x3E4000", Offset = "0x3E2600", VA = "0x1803E4000")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x3E4040", Offset = "0x3E2640", VA = "0x1803E4040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x4E9710", Offset = "0x4E7D10", VA = "0x1804E9710", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x4E9760", Offset = "0x4E7D60", VA = "0x1804E9760")]
		internal void Set(ref UpdateReceivingVolumeCallbackInfoInternal other)
		{
		}
	}
}

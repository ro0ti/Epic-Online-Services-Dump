using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200022E RID: 558
	[Token(Token = "0x200022E")]
	public struct UpdateReceivingCallbackInfo : ICallbackInfo
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00004E8C File Offset: 0x0000308C
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003AF")]
		public Result ResultCode
		{
			[Token(Token = "0x6000F45")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000F46")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B0")]
		public object ClientData
		{
			[Token(Token = "0x6000F47")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F48")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F49")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F4A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B2")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F4B")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F4C")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B3")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000F4D")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F4E")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00004EA4 File Offset: 0x000030A4
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B4")]
		public bool AudioEnabled
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x481820", Offset = "0x47FE20", VA = "0x180481820")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x4818D0", Offset = "0x47FED0", VA = "0x1804818D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x4E8A80", Offset = "0x4E7080", VA = "0x1804E8A80", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x4E8AD0", Offset = "0x4E70D0", VA = "0x1804E8AD0")]
		internal void Set(ref UpdateReceivingCallbackInfoInternal other)
		{
		}
	}
}

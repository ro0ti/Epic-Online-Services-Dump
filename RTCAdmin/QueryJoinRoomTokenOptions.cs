using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x0200024E RID: 590
	[Token(Token = "0x200024E")]
	public struct QueryJoinRoomTokenOptions
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000415")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001049")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600104A")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000416")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600104B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600104C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000417")]
		public ProductUserId[] TargetUserIds
		{
			[Token(Token = "0x600104D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600104E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000418")]
		public Utf8String TargetUserIpAddresses
		{
			[Token(Token = "0x600104F")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001050")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}

using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	public struct PermissionStatus
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008CD")]
		public Utf8String Name
		{
			[Token(Token = "0x6001F4B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F4C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00008744 File Offset: 0x00006944
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008CE")]
		public KWSPermissionStatus Status
		{
			[Token(Token = "0x6001F4D")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return KWSPermissionStatus.Granted;
			}
			[Token(Token = "0x6001F4E")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0x530BA0", Offset = "0x52F1A0", VA = "0x180530BA0")]
		internal void Set(ref PermissionStatusInternal other)
		{
		}
	}
}

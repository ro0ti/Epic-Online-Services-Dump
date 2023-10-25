using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x20002C8")]
	internal struct PresenceModificationSetStatusOptionsInternal : ISettable<PresenceModificationSetStatusOptions>, IDisposable
	{
		// Token: 0x17000516 RID: 1302
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000516")]
		public Status Status
		{
			[Token(Token = "0x600135F")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref PresenceModificationSetStatusOptions other)
		{
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x4FC6D0", Offset = "0x4FACD0", VA = "0x1804FC6D0", Slot = "5")]
		public void Set(ref PresenceModificationSetStatusOptions? other)
		{
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400089E RID: 2206
		[Token(Token = "0x400089E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400089F RID: 2207
		[Token(Token = "0x400089F")]
		[FieldOffset(Offset = "0x4")]
		private Status m_Status;
	}
}

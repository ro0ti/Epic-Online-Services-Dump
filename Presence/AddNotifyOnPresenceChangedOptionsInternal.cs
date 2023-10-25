using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002A4 RID: 676
	[Token(Token = "0x20002A4")]
	internal struct AddNotifyOnPresenceChangedOptionsInternal : ISettable<AddNotifyOnPresenceChangedOptions>, IDisposable
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyOnPresenceChangedOptions other)
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x4EC460", Offset = "0x4EAA60", VA = "0x1804EC460", Slot = "5")]
		public void Set(ref AddNotifyOnPresenceChangedOptions? other)
		{
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}

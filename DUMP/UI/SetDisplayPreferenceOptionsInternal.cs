using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	internal struct SetDisplayPreferenceOptionsInternal : ISettable<SetDisplayPreferenceOptions>, IDisposable
	{
		// Token: 0x170000E0 RID: 224
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E0")]
		public NotificationLocation NotificationLocation
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SetDisplayPreferenceOptions other)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x4AFBA0", Offset = "0x4AE1A0", VA = "0x1804AFBA0", Slot = "5")]
		public void Set(ref SetDisplayPreferenceOptions? other)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x4")]
		private NotificationLocation m_NotificationLocation;
	}
}

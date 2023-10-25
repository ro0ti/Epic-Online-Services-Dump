using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	internal struct ParticipantStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<ParticipantStatusChangedCallbackInfo>, ISettable<ParticipantStatusChangedCallbackInfo>, IDisposable
	{
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700048D")]
		public object ClientData
		{
			[Token(Token = "0x600119A")]
			[Address(RVA = "0x4F8680", Offset = "0x4F6C80", VA = "0x1804F8680")]
			get
			{
				return null;
			}
			[Token(Token = "0x600119B")]
			[Address(RVA = "0x4F8950", Offset = "0x4F6F50", VA = "0x1804F8950")]
			set
			{
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x1700048E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600119C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700048F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600119D")]
			[Address(RVA = "0x4F86F0", Offset = "0x4F6CF0", VA = "0x1804F86F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600119E")]
			[Address(RVA = "0x4F89B0", Offset = "0x4F6FB0", VA = "0x1804F89B0")]
			set
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000490")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600119F")]
			[Address(RVA = "0x4F88E0", Offset = "0x4F6EE0", VA = "0x1804F88E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011A0")]
			[Address(RVA = "0x4F8B50", Offset = "0x4F7150", VA = "0x1804F8B50")]
			set
			{
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000491")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x60011A1")]
			[Address(RVA = "0x4F8770", Offset = "0x4F6D70", VA = "0x1804F8770")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011A2")]
			[Address(RVA = "0x4F8A10", Offset = "0x4F7010", VA = "0x1804F8A10")]
			set
			{
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000055AC File Offset: 0x000037AC
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000492")]
		public RTCParticipantStatus ParticipantStatus
		{
			[Token(Token = "0x60011A3")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return RTCParticipantStatus.Joined;
			}
			[Token(Token = "0x60011A4")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000493")]
		public ParticipantMetadata[] ParticipantMetadata
		{
			[Token(Token = "0x60011A5")]
			[Address(RVA = "0x4F8850", Offset = "0x4F6E50", VA = "0x1804F8850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011A6")]
			[Address(RVA = "0x4F8AD0", Offset = "0x4F70D0", VA = "0x1804F8AD0")]
			set
			{
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000055C4 File Offset: 0x000037C4
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000494")]
		public bool ParticipantInBlocklist
		{
			[Token(Token = "0x60011A7")]
			[Address(RVA = "0x4F87F0", Offset = "0x4F6DF0", VA = "0x1804F87F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011A8")]
			[Address(RVA = "0x4F8A70", Offset = "0x4F7070", VA = "0x1804F8A70")]
			set
			{
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x4F84E0", Offset = "0x4F6AE0", VA = "0x1804F84E0", Slot = "6")]
		public void Set(ref ParticipantStatusChangedCallbackInfo other)
		{
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x4F8290", Offset = "0x4F6890", VA = "0x1804F8290", Slot = "7")]
		public void Set(ref ParticipantStatusChangedCallbackInfo? other)
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x4F81E0", Offset = "0x4F67E0", VA = "0x1804F81E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x4F8260", Offset = "0x4F6860", VA = "0x1804F8260", Slot = "5")]
		public void Get(out ParticipantStatusChangedCallbackInfo output)
		{
		}

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ParticipantId;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x20")]
		private RTCParticipantStatus m_ParticipantStatus;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x24")]
		private uint m_ParticipantMetadataCount;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_ParticipantMetadata;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x30")]
		private int m_ParticipantInBlocklist;
	}
}

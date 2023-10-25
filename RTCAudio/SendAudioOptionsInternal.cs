using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	internal struct SendAudioOptionsInternal : ISettable<SendAudioOptions>, IDisposable
	{
		// Token: 0x1700037B RID: 891
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700037B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000ED5")]
			[Address(RVA = "0x4E4F20", Offset = "0x4E3520", VA = "0x1804E4F20")]
			set
			{
			}
		}

		// Token: 0x1700037C RID: 892
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700037C")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000ED6")]
			[Address(RVA = "0x4E4F80", Offset = "0x4E3580", VA = "0x1804E4F80")]
			set
			{
			}
		}

		// Token: 0x1700037D RID: 893
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700037D")]
		public AudioBuffer? Buffer
		{
			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x4E4EB0", Offset = "0x4E34B0", VA = "0x1804E4EB0")]
			set
			{
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x4E4BF0", Offset = "0x4E31F0", VA = "0x1804E4BF0", Slot = "4")]
		public void Set(ref SendAudioOptions other)
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x4E4D20", Offset = "0x4E3320", VA = "0x1804E4D20", Slot = "5")]
		public void Set(ref SendAudioOptions? other)
		{
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x4E4B80", Offset = "0x4E3180", VA = "0x1804E4B80", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Buffer;
	}
}

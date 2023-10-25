using System;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	internal struct JoinRoomOptionsInternal : ISettable<JoinRoomOptions>, IDisposable
	{
		// Token: 0x17000469 RID: 1129
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000469")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001115")]
			[Address(RVA = "0x4F4FC0", Offset = "0x4F35C0", VA = "0x1804F4FC0")]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700046A")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001116")]
			[Address(RVA = "0x4F51A0", Offset = "0x4F37A0", VA = "0x1804F51A0")]
			set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700046B")]
		public Utf8String ClientBaseUrl
		{
			[Token(Token = "0x6001117")]
			[Address(RVA = "0x4F4F60", Offset = "0x4F3560", VA = "0x1804F4F60")]
			set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700046C")]
		public Utf8String ParticipantToken
		{
			[Token(Token = "0x6001118")]
			[Address(RVA = "0x4F5140", Offset = "0x4F3740", VA = "0x1804F5140")]
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700046D")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6001119")]
			[Address(RVA = "0x4F50E0", Offset = "0x4F36E0", VA = "0x1804F50E0")]
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700046E")]
		public JoinRoomFlags Flags
		{
			[Token(Token = "0x600111A")]
			[Address(RVA = "0x3D2EB0", Offset = "0x3D14B0", VA = "0x1803D2EB0")]
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700046F")]
		public bool ManualAudioInputEnabled
		{
			[Token(Token = "0x600111B")]
			[Address(RVA = "0x4F5020", Offset = "0x4F3620", VA = "0x1804F5020")]
			set
			{
			}
		}

		// Token: 0x17000470 RID: 1136
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000470")]
		public bool ManualAudioOutputEnabled
		{
			[Token(Token = "0x600111C")]
			[Address(RVA = "0x4F5080", Offset = "0x4F3680", VA = "0x1804F5080")]
			set
			{
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x4F4D40", Offset = "0x4F3340", VA = "0x1804F4D40", Slot = "4")]
		public void Set(ref JoinRoomOptions other)
		{
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x4F4A60", Offset = "0x4F3060", VA = "0x1804F4A60", Slot = "5")]
		public void Set(ref JoinRoomOptions? other)
		{
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x4F49E0", Offset = "0x4F2FE0", VA = "0x1804F49E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ClientBaseUrl;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ParticipantToken;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_ParticipantId;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x30")]
		private JoinRoomFlags m_Flags;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x34")]
		private int m_ManualAudioInputEnabled;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x38")]
		private int m_ManualAudioOutputEnabled;
	}
}

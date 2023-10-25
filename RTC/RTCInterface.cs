using System;
using Epic.OnlineServices.RTCAudio;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000280 RID: 640
	[Token(Token = "0x2000280")]
	public sealed class RTCInterface : Handle
	{
		// Token: 0x060011C4 RID: 4548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public RTCInterface()
		{
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public RTCInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x4FEB20", Offset = "0x4FD120", VA = "0x1804FEB20")]
		public ulong AddNotifyDisconnected(ref AddNotifyDisconnectedOptions options, object clientData, OnDisconnectedCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x4FED00", Offset = "0x4FD300", VA = "0x1804FED00")]
		public ulong AddNotifyParticipantStatusChanged(ref AddNotifyParticipantStatusChangedOptions options, object clientData, OnParticipantStatusChangedCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x4FEEE0", Offset = "0x4FD4E0", VA = "0x1804FEEE0")]
		public ulong AddNotifyRoomStatisticsUpdated(ref AddNotifyRoomStatisticsUpdatedOptions options, object clientData, OnRoomStatisticsUpdatedCallback statisticsUpdateHandler)
		{
			return 0UL;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x4FF0C0", Offset = "0x4FD6C0", VA = "0x1804FF0C0")]
		public void BlockParticipant(ref BlockParticipantOptions options, object clientData, OnBlockParticipantCallback completionDelegate)
		{
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x4FF290", Offset = "0x4FD890", VA = "0x1804FF290")]
		public RTCAudioInterface GetAudioInterface()
		{
			return null;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x4FF310", Offset = "0x4FD910", VA = "0x1804FF310")]
		public void JoinRoom(ref JoinRoomOptions options, object clientData, OnJoinRoomCallback completionDelegate)
		{
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x4FF4E0", Offset = "0x4FDAE0", VA = "0x1804FF4E0")]
		public void LeaveRoom(ref LeaveRoomOptions options, object clientData, OnLeaveRoomCallback completionDelegate)
		{
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x4FFAA0", Offset = "0x4FE0A0", VA = "0x1804FFAA0")]
		public void RemoveNotifyDisconnected(ulong notificationId)
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x4FFB10", Offset = "0x4FE110", VA = "0x1804FFB10")]
		public void RemoveNotifyParticipantStatusChanged(ulong notificationId)
		{
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x4FFB80", Offset = "0x4FE180", VA = "0x1804FFB80")]
		public void RemoveNotifyRoomStatisticsUpdated(ulong notificationId)
		{
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x4FFBF0", Offset = "0x4FE1F0", VA = "0x1804FFBF0")]
		public Result SetRoomSetting(ref SetRoomSettingOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x4FFCA0", Offset = "0x4FE2A0", VA = "0x1804FFCA0")]
		public Result SetSetting(ref SetSettingOptions options)
		{
			return Result.Success;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x4FF6B0", Offset = "0x4FDCB0", VA = "0x1804FF6B0")]
		[MonoPInvokeCallback(typeof(OnBlockParticipantCallbackInternal))]
		internal static void OnBlockParticipantCallbackInternalImplementation(ref BlockParticipantCallbackInfoInternal data)
		{
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x4FF760", Offset = "0x4FDD60", VA = "0x1804FF760")]
		[MonoPInvokeCallback(typeof(OnDisconnectedCallbackInternal))]
		internal static void OnDisconnectedCallbackInternalImplementation(ref DisconnectedCallbackInfoInternal data)
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x4FF800", Offset = "0x4FDE00", VA = "0x1804FF800")]
		[MonoPInvokeCallback(typeof(OnJoinRoomCallbackInternal))]
		internal static void OnJoinRoomCallbackInternalImplementation(ref JoinRoomCallbackInfoInternal data)
		{
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x4FF8B0", Offset = "0x4FDEB0", VA = "0x1804FF8B0")]
		[MonoPInvokeCallback(typeof(OnLeaveRoomCallbackInternal))]
		internal static void OnLeaveRoomCallbackInternalImplementation(ref LeaveRoomCallbackInfoInternal data)
		{
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x4FF950", Offset = "0x4FDF50", VA = "0x1804FF950")]
		[MonoPInvokeCallback(typeof(OnParticipantStatusChangedCallbackInternal))]
		internal static void OnParticipantStatusChangedCallbackInternalImplementation(ref ParticipantStatusChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x4FFA00", Offset = "0x4FE000", VA = "0x1804FFA00")]
		[MonoPInvokeCallback(typeof(OnRoomStatisticsUpdatedCallbackInternal))]
		internal static void OnRoomStatisticsUpdatedCallbackInternalImplementation(ref RoomStatisticsUpdatedInfoInternal data)
		{
		}

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		public const int AddnotifydisconnectedApiLatest = 1;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		public const int AddnotifyparticipantstatuschangedApiLatest = 1;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		public const int AddnotifyroomstatisticsupdatedApiLatest = 1;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		public const int BlockparticipantApiLatest = 1;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		public const int JoinroomApiLatest = 1;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		public const int LeaveroomApiLatest = 1;

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		public const int OptionApiLatest = 1;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		public const int OptionKeyMaxcharcount = 256;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		public const int OptionValueMaxcharcount = 256;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		public const int ParticipantmetadataApiLatest = 1;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		public const int ParticipantmetadataKeyMaxcharcount = 256;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		public const int ParticipantmetadataValueMaxcharcount = 256;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		public const int SetroomsettingApiLatest = 1;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		public const int SetsettingApiLatest = 1;
	}
}

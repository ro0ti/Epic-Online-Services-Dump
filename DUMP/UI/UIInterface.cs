using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public sealed class UIInterface : Handle
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public UIInterface()
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x49FCF0", Offset = "0x49E2F0", VA = "0x18049FCF0")]
		public UIInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x4B2040", Offset = "0x4B0640", VA = "0x1804B2040")]
		public Result AcknowledgeEventId(ref AcknowledgeEventIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x4B2140", Offset = "0x4B0740", VA = "0x1804B2140")]
		public ulong AddNotifyDisplaySettingsUpdated(ref AddNotifyDisplaySettingsUpdatedOptions options, object clientData, OnDisplaySettingsUpdatedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x4B2370", Offset = "0x4B0970", VA = "0x1804B2370")]
		public ulong AddNotifyMemoryMonitor(ref AddNotifyMemoryMonitorOptions options, object clientData, OnMemoryMonitorCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x4B25A0", Offset = "0x4B0BA0", VA = "0x1804B25A0")]
		public bool GetFriendsExclusiveInput(ref GetFriendsExclusiveInputOptions options)
		{
			return default(bool);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x4B2760", Offset = "0x4B0D60", VA = "0x1804B2760")]
		public bool GetFriendsVisible(ref GetFriendsVisibleOptions options)
		{
			return default(bool);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x4B2920", Offset = "0x4B0F20", VA = "0x1804B2920")]
		public NotificationLocation GetNotificationLocationPreference()
		{
			return NotificationLocation.TopLeft;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x4B29A0", Offset = "0x4B0FA0", VA = "0x1804B29A0")]
		public InputStateButtonFlags GetToggleFriendsButton(ref GetToggleFriendsButtonOptions options)
		{
			return InputStateButtonFlags.None;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x4B2A80", Offset = "0x4B1080", VA = "0x1804B2A80")]
		public KeyCombination GetToggleFriendsKey(ref GetToggleFriendsKeyOptions options)
		{
			return KeyCombination.None;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x4B2B60", Offset = "0x4B1160", VA = "0x1804B2B60")]
		public void HideFriends(ref HideFriendsOptions options, object clientData, OnHideFriendsCallback completionDelegate)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x4B2E10", Offset = "0x4B1410", VA = "0x1804B2E10")]
		public bool IsSocialOverlayPaused(ref IsSocialOverlayPausedOptions options)
		{
			return default(bool);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x4B2F30", Offset = "0x4B1530", VA = "0x1804B2F30")]
		public bool IsValidButtonCombination(InputStateButtonFlags buttonCombination)
		{
			return default(bool);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x4B3030", Offset = "0x4B1630", VA = "0x1804B3030")]
		public bool IsValidKeyCombination(KeyCombination keyCombination)
		{
			return default(bool);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x4B3590", Offset = "0x4B1B90", VA = "0x1804B3590")]
		public Result PauseSocialOverlay(ref PauseSocialOverlayOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x4B36F0", Offset = "0x4B1CF0", VA = "0x1804B36F0")]
		public Result PrePresent(ref PrePresentOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x4B37E0", Offset = "0x4B1DE0", VA = "0x1804B37E0")]
		public void RemoveNotifyDisplaySettingsUpdated(ulong id)
		{
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x4B38B0", Offset = "0x4B1EB0", VA = "0x1804B38B0")]
		public void RemoveNotifyMemoryMonitor(ulong id)
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x4B3980", Offset = "0x4B1F80", VA = "0x1804B3980")]
		public Result ReportInputState(ref ReportInputStateOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x4B3B90", Offset = "0x4B2190", VA = "0x1804B3B90")]
		public Result SetDisplayPreference(ref SetDisplayPreferenceOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x4B3C80", Offset = "0x4B2280", VA = "0x1804B3C80")]
		public Result SetToggleFriendsButton(ref SetToggleFriendsButtonOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x4B3D70", Offset = "0x4B2370", VA = "0x1804B3D70")]
		public Result SetToggleFriendsKey(ref SetToggleFriendsKeyOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x4B3E60", Offset = "0x4B2460", VA = "0x1804B3E60")]
		public void ShowBlockPlayer(ref ShowBlockPlayerOptions options, object clientData, OnShowBlockPlayerCallback completionDelegate)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x4B41B0", Offset = "0x4B27B0", VA = "0x1804B41B0")]
		public void ShowFriends(ref ShowFriendsOptions options, object clientData, OnShowFriendsCallback completionDelegate)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x4B4460", Offset = "0x4B2A60", VA = "0x1804B4460")]
		public void ShowNativeProfile(ref ShowNativeProfileOptions options, object clientData, OnShowNativeProfileCallback completionDelegate)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x4B47B0", Offset = "0x4B2DB0", VA = "0x1804B47B0")]
		public void ShowReportPlayer(ref ShowReportPlayerOptions options, object clientData, OnShowReportPlayerCallback completionDelegate)
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x4B3130", Offset = "0x4B1730", VA = "0x1804B3130")]
		[MonoPInvokeCallback(typeof(OnDisplaySettingsUpdatedCallbackInternal))]
		internal static void OnDisplaySettingsUpdatedCallbackInternalImplementation(ref OnDisplaySettingsUpdatedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x4B31D0", Offset = "0x4B17D0", VA = "0x1804B31D0")]
		[MonoPInvokeCallback(typeof(OnHideFriendsCallbackInternal))]
		internal static void OnHideFriendsCallbackInternalImplementation(ref HideFriendsCallbackInfoInternal data)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x4B3270", Offset = "0x4B1870", VA = "0x1804B3270")]
		[MonoPInvokeCallback(typeof(OnMemoryMonitorCallbackInternal))]
		internal static void OnMemoryMonitorCallbackInternalImplementation(ref MemoryMonitorCallbackInfoInternal data)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x4B3310", Offset = "0x4B1910", VA = "0x1804B3310")]
		[MonoPInvokeCallback(typeof(OnShowBlockPlayerCallbackInternal))]
		internal static void OnShowBlockPlayerCallbackInternalImplementation(ref OnShowBlockPlayerCallbackInfoInternal data)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x4B33B0", Offset = "0x4B19B0", VA = "0x1804B33B0")]
		[MonoPInvokeCallback(typeof(OnShowFriendsCallbackInternal))]
		internal static void OnShowFriendsCallbackInternalImplementation(ref ShowFriendsCallbackInfoInternal data)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x4B3450", Offset = "0x4B1A50", VA = "0x1804B3450")]
		[MonoPInvokeCallback(typeof(OnShowNativeProfileCallbackInternal))]
		internal static void OnShowNativeProfileCallbackInternalImplementation(ref ShowNativeProfileCallbackInfoInternal data)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x4B34F0", Offset = "0x4B1AF0", VA = "0x1804B34F0")]
		[MonoPInvokeCallback(typeof(OnShowReportPlayerCallbackInternal))]
		internal static void OnShowReportPlayerCallbackInternalImplementation(ref OnShowReportPlayerCallbackInfoInternal data)
		{
		}

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		public const int AcknowledgecorrelationidApiLatest = 1;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		public const int AcknowledgeeventidApiLatest = 1;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		public const int AddnotifydisplaysettingsupdatedApiLatest = 1;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		public const int AddnotifymemorymonitorApiLatest = 1;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		public const int AddnotifymemorymonitoroptionsApiLatest = 1;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		public const int EventidInvalid = 0;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		public const int GetfriendsexclusiveinputApiLatest = 1;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		public const int GetfriendsvisibleApiLatest = 1;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		public const int GettogglefriendsbuttonApiLatest = 1;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		public const int GettogglefriendskeyApiLatest = 1;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		public const int HidefriendsApiLatest = 1;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		public const int IssocialoverlaypausedApiLatest = 1;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		public const int MemorymonitorcallbackinfoApiLatest = 1;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		public const int PausesocialoverlayApiLatest = 1;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		public const int PrepresentApiLatest = 1;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		public const int RectApiLatest = 1;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		public const int ReportinputstateApiLatest = 2;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		public const int SetdisplaypreferenceApiLatest = 1;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		public const int SettogglefriendsbuttonApiLatest = 1;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		public const int SettogglefriendskeyApiLatest = 1;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		public const int ShowblockplayerApiLatest = 1;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		public const int ShowfriendsApiLatest = 1;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		public const int ShownativeprofileApiLatest = 1;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		public const int ShowreportplayerApiLatest = 1;
	}
}

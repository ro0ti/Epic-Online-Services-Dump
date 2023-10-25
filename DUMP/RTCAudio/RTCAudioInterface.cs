using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public sealed class RTCAudioInterface : Handle
	{
		// Token: 0x06000E98 RID: 3736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public RTCAudioInterface()
		{
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public RTCAudioInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x4E0D70", Offset = "0x4DF370", VA = "0x1804E0D70")]
		public ulong AddNotifyAudioBeforeRender(ref AddNotifyAudioBeforeRenderOptions options, object clientData, OnAudioBeforeRenderCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x4E0F50", Offset = "0x4DF550", VA = "0x1804E0F50")]
		public ulong AddNotifyAudioBeforeSend(ref AddNotifyAudioBeforeSendOptions options, object clientData, OnAudioBeforeSendCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x4E1130", Offset = "0x4DF730", VA = "0x1804E1130")]
		public ulong AddNotifyAudioDevicesChanged(ref AddNotifyAudioDevicesChangedOptions options, object clientData, OnAudioDevicesChangedCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x4E12F0", Offset = "0x4DF8F0", VA = "0x1804E12F0")]
		public ulong AddNotifyAudioInputState(ref AddNotifyAudioInputStateOptions options, object clientData, OnAudioInputStateCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x4E14D0", Offset = "0x4DFAD0", VA = "0x1804E14D0")]
		public ulong AddNotifyAudioOutputState(ref AddNotifyAudioOutputStateOptions options, object clientData, OnAudioOutputStateCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x4E16B0", Offset = "0x4DFCB0", VA = "0x1804E16B0")]
		public ulong AddNotifyParticipantUpdated(ref AddNotifyParticipantUpdatedOptions options, object clientData, OnParticipantUpdatedCallback completionDelegate)
		{
			return 0UL;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x4E1890", Offset = "0x4DFE90", VA = "0x1804E1890")]
		public Result CopyInputDeviceInformationByIndex(ref CopyInputDeviceInformationByIndexOptions options, out InputDeviceInformation? outInputDeviceInformation)
		{
			return Result.Success;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x4E1980", Offset = "0x4DFF80", VA = "0x1804E1980")]
		public Result CopyOutputDeviceInformationByIndex(ref CopyOutputDeviceInformationByIndexOptions options, out OutputDeviceInformation? outOutputDeviceInformation)
		{
			return Result.Success;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x4E1A70", Offset = "0x4E0070", VA = "0x1804E1A70")]
		public AudioInputDeviceInfo? GetAudioInputDeviceByIndex(ref GetAudioInputDeviceByIndexOptions options)
		{
			return null;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x4E1B40", Offset = "0x4E0140", VA = "0x1804E1B40")]
		public uint GetAudioInputDevicesCount(ref GetAudioInputDevicesCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x4E1BC0", Offset = "0x4E01C0", VA = "0x1804E1BC0")]
		public AudioOutputDeviceInfo? GetAudioOutputDeviceByIndex(ref GetAudioOutputDeviceByIndexOptions options)
		{
			return null;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x4E1C90", Offset = "0x4E0290", VA = "0x1804E1C90")]
		public uint GetAudioOutputDevicesCount(ref GetAudioOutputDevicesCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x4E1D10", Offset = "0x4E0310", VA = "0x1804E1D10")]
		public uint GetInputDevicesCount(ref GetInputDevicesCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x4E1D90", Offset = "0x4E0390", VA = "0x1804E1D90")]
		public uint GetOutputDevicesCount(ref GetOutputDevicesCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x4E2930", Offset = "0x4E0F30", VA = "0x1804E2930")]
		public void QueryInputDevicesInformation(ref QueryInputDevicesInformationOptions options, object clientData, OnQueryInputDevicesInformationCallback completionDelegate)
		{
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x4E2AE0", Offset = "0x4E10E0", VA = "0x1804E2AE0")]
		public void QueryOutputDevicesInformation(ref QueryOutputDevicesInformationOptions options, object clientData, OnQueryOutputDevicesInformationCallback completionDelegate)
		{
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x4E2C90", Offset = "0x4E1290", VA = "0x1804E2C90")]
		public Result RegisterPlatformAudioUser(ref RegisterPlatformAudioUserOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x4E2D70", Offset = "0x4E1370", VA = "0x1804E2D70")]
		public void RegisterPlatformUser(ref RegisterPlatformUserOptions options, object clientData, OnRegisterPlatformUserCallback completionDelegate)
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x4E2F70", Offset = "0x4E1570", VA = "0x1804E2F70")]
		public void RemoveNotifyAudioBeforeRender(ulong notificationId)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x4E2FE0", Offset = "0x4E15E0", VA = "0x1804E2FE0")]
		public void RemoveNotifyAudioBeforeSend(ulong notificationId)
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x4E3050", Offset = "0x4E1650", VA = "0x1804E3050")]
		public void RemoveNotifyAudioDevicesChanged(ulong notificationId)
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x4E30C0", Offset = "0x4E16C0", VA = "0x1804E30C0")]
		public void RemoveNotifyAudioInputState(ulong notificationId)
		{
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x4E3130", Offset = "0x4E1730", VA = "0x1804E3130")]
		public void RemoveNotifyAudioOutputState(ulong notificationId)
		{
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x4E31A0", Offset = "0x4E17A0", VA = "0x1804E31A0")]
		public void RemoveNotifyParticipantUpdated(ulong notificationId)
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x4E3210", Offset = "0x4E1810", VA = "0x1804E3210")]
		public Result SendAudio(ref SendAudioOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x4E32B0", Offset = "0x4E18B0", VA = "0x1804E32B0")]
		public Result SetAudioInputSettings(ref SetAudioInputSettingsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x4E3350", Offset = "0x4E1950", VA = "0x1804E3350")]
		public Result SetAudioOutputSettings(ref SetAudioOutputSettingsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x4E33F0", Offset = "0x4E19F0", VA = "0x1804E33F0")]
		public void SetInputDeviceSettings(ref SetInputDeviceSettingsOptions options, object clientData, OnSetInputDeviceSettingsCallback completionDelegate)
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x4E35C0", Offset = "0x4E1BC0", VA = "0x1804E35C0")]
		public void SetOutputDeviceSettings(ref SetOutputDeviceSettingsOptions options, object clientData, OnSetOutputDeviceSettingsCallback completionDelegate)
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x4E3790", Offset = "0x4E1D90", VA = "0x1804E3790")]
		public Result UnregisterPlatformAudioUser(ref UnregisterPlatformAudioUserOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x4E3870", Offset = "0x4E1E70", VA = "0x1804E3870")]
		public void UnregisterPlatformUser(ref UnregisterPlatformUserOptions options, object clientData, OnUnregisterPlatformUserCallback completionDelegate)
		{
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x4E3A70", Offset = "0x4E2070", VA = "0x1804E3A70")]
		public void UpdateParticipantVolume(ref UpdateParticipantVolumeOptions options, object clientData, OnUpdateParticipantVolumeCallback completionDelegate)
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x4E3E10", Offset = "0x4E2410", VA = "0x1804E3E10")]
		public void UpdateReceiving(ref UpdateReceivingOptions options, object clientData, OnUpdateReceivingCallback completionDelegate)
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x4E3C40", Offset = "0x4E2240", VA = "0x1804E3C40")]
		public void UpdateReceivingVolume(ref UpdateReceivingVolumeOptions options, object clientData, OnUpdateReceivingVolumeCallback completionDelegate)
		{
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x4E41B0", Offset = "0x4E27B0", VA = "0x1804E41B0")]
		public void UpdateSending(ref UpdateSendingOptions options, object clientData, OnUpdateSendingCallback completionDelegate)
		{
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x4E3FE0", Offset = "0x4E25E0", VA = "0x1804E3FE0")]
		public void UpdateSendingVolume(ref UpdateSendingVolumeOptions options, object clientData, OnUpdateSendingVolumeCallback completionDelegate)
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x4E1E10", Offset = "0x4E0410", VA = "0x1804E1E10")]
		[MonoPInvokeCallback(typeof(OnAudioBeforeRenderCallbackInternal))]
		internal static void OnAudioBeforeRenderCallbackInternalImplementation(ref AudioBeforeRenderCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x4E1EC0", Offset = "0x4E04C0", VA = "0x1804E1EC0")]
		[MonoPInvokeCallback(typeof(OnAudioBeforeSendCallbackInternal))]
		internal static void OnAudioBeforeSendCallbackInternalImplementation(ref AudioBeforeSendCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x4E1F70", Offset = "0x4E0570", VA = "0x1804E1F70")]
		[MonoPInvokeCallback(typeof(OnAudioDevicesChangedCallbackInternal))]
		internal static void OnAudioDevicesChangedCallbackInternalImplementation(ref AudioDevicesChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x4E2010", Offset = "0x4E0610", VA = "0x1804E2010")]
		[MonoPInvokeCallback(typeof(OnAudioInputStateCallbackInternal))]
		internal static void OnAudioInputStateCallbackInternalImplementation(ref AudioInputStateCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x4E20B0", Offset = "0x4E06B0", VA = "0x1804E20B0")]
		[MonoPInvokeCallback(typeof(OnAudioOutputStateCallbackInternal))]
		internal static void OnAudioOutputStateCallbackInternalImplementation(ref AudioOutputStateCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x4E2150", Offset = "0x4E0750", VA = "0x1804E2150")]
		[MonoPInvokeCallback(typeof(OnParticipantUpdatedCallbackInternal))]
		internal static void OnParticipantUpdatedCallbackInternalImplementation(ref ParticipantUpdatedCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x4E2200", Offset = "0x4E0800", VA = "0x1804E2200")]
		[MonoPInvokeCallback(typeof(OnQueryInputDevicesInformationCallbackInternal))]
		internal static void OnQueryInputDevicesInformationCallbackInternalImplementation(ref OnQueryInputDevicesInformationCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x4E22A0", Offset = "0x4E08A0", VA = "0x1804E22A0")]
		[MonoPInvokeCallback(typeof(OnQueryOutputDevicesInformationCallbackInternal))]
		internal static void OnQueryOutputDevicesInformationCallbackInternalImplementation(ref OnQueryOutputDevicesInformationCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x4E2340", Offset = "0x4E0940", VA = "0x1804E2340")]
		[MonoPInvokeCallback(typeof(OnRegisterPlatformUserCallbackInternal))]
		internal static void OnRegisterPlatformUserCallbackInternalImplementation(ref OnRegisterPlatformUserCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x4E23E0", Offset = "0x4E09E0", VA = "0x1804E23E0")]
		[MonoPInvokeCallback(typeof(OnSetInputDeviceSettingsCallbackInternal))]
		internal static void OnSetInputDeviceSettingsCallbackInternalImplementation(ref OnSetInputDeviceSettingsCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x4E2480", Offset = "0x4E0A80", VA = "0x1804E2480")]
		[MonoPInvokeCallback(typeof(OnSetOutputDeviceSettingsCallbackInternal))]
		internal static void OnSetOutputDeviceSettingsCallbackInternalImplementation(ref OnSetOutputDeviceSettingsCallbackInfoInternal data)
		{
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x4E2520", Offset = "0x4E0B20", VA = "0x1804E2520")]
		[MonoPInvokeCallback(typeof(OnUnregisterPlatformUserCallbackInternal))]
		internal static void OnUnregisterPlatformUserCallbackInternalImplementation(ref OnUnregisterPlatformUserCallbackInfoInternal data)
		{
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x4E25C0", Offset = "0x4E0BC0", VA = "0x1804E25C0")]
		[MonoPInvokeCallback(typeof(OnUpdateParticipantVolumeCallbackInternal))]
		internal static void OnUpdateParticipantVolumeCallbackInternalImplementation(ref UpdateParticipantVolumeCallbackInfoInternal data)
		{
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x4E2670", Offset = "0x4E0C70", VA = "0x1804E2670")]
		[MonoPInvokeCallback(typeof(OnUpdateReceivingCallbackInternal))]
		internal static void OnUpdateReceivingCallbackInternalImplementation(ref UpdateReceivingCallbackInfoInternal data)
		{
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x4E2720", Offset = "0x4E0D20", VA = "0x1804E2720")]
		[MonoPInvokeCallback(typeof(OnUpdateReceivingVolumeCallbackInternal))]
		internal static void OnUpdateReceivingVolumeCallbackInternalImplementation(ref UpdateReceivingVolumeCallbackInfoInternal data)
		{
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x4E27D0", Offset = "0x4E0DD0", VA = "0x1804E27D0")]
		[MonoPInvokeCallback(typeof(OnUpdateSendingCallbackInternal))]
		internal static void OnUpdateSendingCallbackInternalImplementation(ref UpdateSendingCallbackInfoInternal data)
		{
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x4E2880", Offset = "0x4E0E80", VA = "0x1804E2880")]
		[MonoPInvokeCallback(typeof(OnUpdateSendingVolumeCallbackInternal))]
		internal static void OnUpdateSendingVolumeCallbackInternalImplementation(ref UpdateSendingVolumeCallbackInfoInternal data)
		{
		}

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		public const int AddnotifyaudiobeforerenderApiLatest = 1;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		public const int AddnotifyaudiobeforesendApiLatest = 1;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		public const int AddnotifyaudiodeviceschangedApiLatest = 1;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		public const int AddnotifyaudioinputstateApiLatest = 1;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		public const int AddnotifyaudiooutputstateApiLatest = 1;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		public const int AddnotifyparticipantupdatedApiLatest = 1;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		public const int AudiobufferApiLatest = 1;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		public const int AudioinputdeviceinfoApiLatest = 1;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		public const int AudiooutputdeviceinfoApiLatest = 1;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		public const int CopyinputdeviceinformationbyindexApiLatest = 1;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		public const int CopyoutputdeviceinformationbyindexApiLatest = 1;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		public const int GetaudioinputdevicebyindexApiLatest = 1;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		public const int GetaudioinputdevicescountApiLatest = 1;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		public const int GetaudiooutputdevicebyindexApiLatest = 1;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		public const int GetaudiooutputdevicescountApiLatest = 1;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		public const int GetinputdevicescountApiLatest = 1;

		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		public const int GetoutputdevicescountApiLatest = 1;

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		public const int InputdeviceinformationApiLatest = 1;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		public const int OutputdeviceinformationApiLatest = 1;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		public const int QueryinputdevicesinformationApiLatest = 1;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		public const int QueryoutputdevicesinformationApiLatest = 1;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		public const int RegisterplatformaudiouserApiLatest = 1;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		public const int RegisterplatformuserApiLatest = 1;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		public const int SendaudioApiLatest = 1;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		public const int SetaudioinputsettingsApiLatest = 1;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		public const int SetaudiooutputsettingsApiLatest = 1;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		public const int SetinputdevicesettingsApiLatest = 1;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		public const int SetoutputdevicesettingsApiLatest = 1;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		public const int UnregisterplatformaudiouserApiLatest = 1;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		public const int UnregisterplatformuserApiLatest = 1;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		public const int UpdateparticipantvolumeApiLatest = 1;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		public const int UpdatereceivingApiLatest = 1;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		public const int UpdatereceivingvolumeApiLatest = 1;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		public const int UpdatesendingApiLatest = 1;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		public const int UpdatesendingvolumeApiLatest = 1;
	}
}


#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_max_request_duration")]
        public int? ApiMaxRequestDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_max_pool_size")]
        public int? DbMaxPoolSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_max_pool_size_unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AuthConfigResponseDbMaxPoolSizeUnitJsonConverter))]
        public global::Supabase.AuthConfigResponseDbMaxPoolSizeUnit? DbMaxPoolSizeUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_signup")]
        public bool? DisableSignup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_anonymous_users_enabled")]
        public bool? ExternalAnonymousUsersEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_apple_additional_client_ids")]
        public string? ExternalAppleAdditionalClientIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_apple_client_id")]
        public string? ExternalAppleClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_apple_email_optional")]
        public bool? ExternalAppleEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_apple_enabled")]
        public bool? ExternalAppleEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_apple_secret")]
        public string? ExternalAppleSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_azure_client_id")]
        public string? ExternalAzureClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_azure_email_optional")]
        public bool? ExternalAzureEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_azure_enabled")]
        public bool? ExternalAzureEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_azure_secret")]
        public string? ExternalAzureSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_azure_url")]
        public string? ExternalAzureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_bitbucket_client_id")]
        public string? ExternalBitbucketClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_bitbucket_email_optional")]
        public bool? ExternalBitbucketEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_bitbucket_enabled")]
        public bool? ExternalBitbucketEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_bitbucket_secret")]
        public string? ExternalBitbucketSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_discord_client_id")]
        public string? ExternalDiscordClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_discord_email_optional")]
        public bool? ExternalDiscordEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_discord_enabled")]
        public bool? ExternalDiscordEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_discord_secret")]
        public string? ExternalDiscordSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_email_enabled")]
        public bool? ExternalEmailEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_facebook_client_id")]
        public string? ExternalFacebookClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_facebook_email_optional")]
        public bool? ExternalFacebookEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_facebook_enabled")]
        public bool? ExternalFacebookEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_facebook_secret")]
        public string? ExternalFacebookSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_figma_client_id")]
        public string? ExternalFigmaClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_figma_email_optional")]
        public bool? ExternalFigmaEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_figma_enabled")]
        public bool? ExternalFigmaEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_figma_secret")]
        public string? ExternalFigmaSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_github_client_id")]
        public string? ExternalGithubClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_github_email_optional")]
        public bool? ExternalGithubEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_github_enabled")]
        public bool? ExternalGithubEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_github_secret")]
        public string? ExternalGithubSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_gitlab_client_id")]
        public string? ExternalGitlabClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_gitlab_email_optional")]
        public bool? ExternalGitlabEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_gitlab_enabled")]
        public bool? ExternalGitlabEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_gitlab_secret")]
        public string? ExternalGitlabSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_gitlab_url")]
        public string? ExternalGitlabUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_google_additional_client_ids")]
        public string? ExternalGoogleAdditionalClientIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_google_client_id")]
        public string? ExternalGoogleClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_google_email_optional")]
        public bool? ExternalGoogleEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_google_enabled")]
        public bool? ExternalGoogleEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_google_secret")]
        public string? ExternalGoogleSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_google_skip_nonce_check")]
        public bool? ExternalGoogleSkipNonceCheck { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_kakao_client_id")]
        public string? ExternalKakaoClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_kakao_email_optional")]
        public bool? ExternalKakaoEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_kakao_enabled")]
        public bool? ExternalKakaoEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_kakao_secret")]
        public string? ExternalKakaoSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_keycloak_client_id")]
        public string? ExternalKeycloakClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_keycloak_email_optional")]
        public bool? ExternalKeycloakEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_keycloak_enabled")]
        public bool? ExternalKeycloakEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_keycloak_secret")]
        public string? ExternalKeycloakSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_keycloak_url")]
        public string? ExternalKeycloakUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_linkedin_oidc_client_id")]
        public string? ExternalLinkedinOidcClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_linkedin_oidc_email_optional")]
        public bool? ExternalLinkedinOidcEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_linkedin_oidc_enabled")]
        public bool? ExternalLinkedinOidcEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_linkedin_oidc_secret")]
        public string? ExternalLinkedinOidcSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_oidc_client_id")]
        public string? ExternalSlackOidcClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_oidc_email_optional")]
        public bool? ExternalSlackOidcEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_oidc_enabled")]
        public bool? ExternalSlackOidcEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_oidc_secret")]
        public string? ExternalSlackOidcSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_notion_client_id")]
        public string? ExternalNotionClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_notion_email_optional")]
        public bool? ExternalNotionEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_notion_enabled")]
        public bool? ExternalNotionEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_notion_secret")]
        public string? ExternalNotionSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_phone_enabled")]
        public bool? ExternalPhoneEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_client_id")]
        public string? ExternalSlackClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_email_optional")]
        public bool? ExternalSlackEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_enabled")]
        public bool? ExternalSlackEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_slack_secret")]
        public string? ExternalSlackSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_spotify_client_id")]
        public string? ExternalSpotifyClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_spotify_email_optional")]
        public bool? ExternalSpotifyEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_spotify_enabled")]
        public bool? ExternalSpotifyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_spotify_secret")]
        public string? ExternalSpotifySecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitch_client_id")]
        public string? ExternalTwitchClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitch_email_optional")]
        public bool? ExternalTwitchEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitch_enabled")]
        public bool? ExternalTwitchEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitch_secret")]
        public string? ExternalTwitchSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitter_client_id")]
        public string? ExternalTwitterClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitter_email_optional")]
        public bool? ExternalTwitterEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitter_enabled")]
        public bool? ExternalTwitterEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_twitter_secret")]
        public string? ExternalTwitterSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_x_client_id")]
        public string? ExternalXClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_x_email_optional")]
        public bool? ExternalXEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_x_enabled")]
        public bool? ExternalXEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_x_secret")]
        public string? ExternalXSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_workos_client_id")]
        public string? ExternalWorkosClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_workos_enabled")]
        public bool? ExternalWorkosEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_workos_secret")]
        public string? ExternalWorkosSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_workos_url")]
        public string? ExternalWorkosUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_web3_solana_enabled")]
        public bool? ExternalWeb3SolanaEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_web3_ethereum_enabled")]
        public bool? ExternalWeb3EthereumEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_zoom_client_id")]
        public string? ExternalZoomClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_zoom_email_optional")]
        public bool? ExternalZoomEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_zoom_enabled")]
        public bool? ExternalZoomEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_zoom_secret")]
        public string? ExternalZoomSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_custom_access_token_enabled")]
        public bool? HookCustomAccessTokenEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_custom_access_token_uri")]
        public string? HookCustomAccessTokenUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_custom_access_token_secrets")]
        public string? HookCustomAccessTokenSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_mfa_verification_attempt_enabled")]
        public bool? HookMfaVerificationAttemptEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_mfa_verification_attempt_uri")]
        public string? HookMfaVerificationAttemptUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_mfa_verification_attempt_secrets")]
        public string? HookMfaVerificationAttemptSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_password_verification_attempt_enabled")]
        public bool? HookPasswordVerificationAttemptEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_password_verification_attempt_uri")]
        public string? HookPasswordVerificationAttemptUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_password_verification_attempt_secrets")]
        public string? HookPasswordVerificationAttemptSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_send_sms_enabled")]
        public bool? HookSendSmsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_send_sms_uri")]
        public string? HookSendSmsUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_send_sms_secrets")]
        public string? HookSendSmsSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_send_email_enabled")]
        public bool? HookSendEmailEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_send_email_uri")]
        public string? HookSendEmailUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_send_email_secrets")]
        public string? HookSendEmailSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_before_user_created_enabled")]
        public bool? HookBeforeUserCreatedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_before_user_created_uri")]
        public string? HookBeforeUserCreatedUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_before_user_created_secrets")]
        public string? HookBeforeUserCreatedSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_after_user_created_enabled")]
        public bool? HookAfterUserCreatedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_after_user_created_uri")]
        public string? HookAfterUserCreatedUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_after_user_created_secrets")]
        public string? HookAfterUserCreatedSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_exp")]
        public int? JwtExp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_allow_unverified_email_sign_ins")]
        public bool? MailerAllowUnverifiedEmailSignIns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_autoconfirm")]
        public bool? MailerAutoconfirm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_otp_exp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MailerOtpExp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_otp_length")]
        public int? MailerOtpLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_secure_email_change_enabled")]
        public bool? MailerSecureEmailChangeEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_confirmation")]
        public string? MailerSubjectsConfirmation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_email_change")]
        public string? MailerSubjectsEmailChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_invite")]
        public string? MailerSubjectsInvite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_magic_link")]
        public string? MailerSubjectsMagicLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_reauthentication")]
        public string? MailerSubjectsReauthentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_recovery")]
        public string? MailerSubjectsRecovery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_password_changed_notification")]
        public string? MailerSubjectsPasswordChangedNotification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_email_changed_notification")]
        public string? MailerSubjectsEmailChangedNotification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_phone_changed_notification")]
        public string? MailerSubjectsPhoneChangedNotification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_mfa_factor_enrolled_notification")]
        public string? MailerSubjectsMfaFactorEnrolledNotification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_mfa_factor_unenrolled_notification")]
        public string? MailerSubjectsMfaFactorUnenrolledNotification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_identity_linked_notification")]
        public string? MailerSubjectsIdentityLinkedNotification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_subjects_identity_unlinked_notification")]
        public string? MailerSubjectsIdentityUnlinkedNotification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_confirmation_content")]
        public string? MailerTemplatesConfirmationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_email_change_content")]
        public string? MailerTemplatesEmailChangeContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_invite_content")]
        public string? MailerTemplatesInviteContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_magic_link_content")]
        public string? MailerTemplatesMagicLinkContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_reauthentication_content")]
        public string? MailerTemplatesReauthenticationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_recovery_content")]
        public string? MailerTemplatesRecoveryContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_password_changed_notification_content")]
        public string? MailerTemplatesPasswordChangedNotificationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_email_changed_notification_content")]
        public string? MailerTemplatesEmailChangedNotificationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_phone_changed_notification_content")]
        public string? MailerTemplatesPhoneChangedNotificationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_mfa_factor_enrolled_notification_content")]
        public string? MailerTemplatesMfaFactorEnrolledNotificationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_mfa_factor_unenrolled_notification_content")]
        public string? MailerTemplatesMfaFactorUnenrolledNotificationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_identity_linked_notification_content")]
        public string? MailerTemplatesIdentityLinkedNotificationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_templates_identity_unlinked_notification_content")]
        public string? MailerTemplatesIdentityUnlinkedNotificationContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_notifications_password_changed_enabled")]
        public bool? MailerNotificationsPasswordChangedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_notifications_email_changed_enabled")]
        public bool? MailerNotificationsEmailChangedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_notifications_phone_changed_enabled")]
        public bool? MailerNotificationsPhoneChangedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_notifications_mfa_factor_enrolled_enabled")]
        public bool? MailerNotificationsMfaFactorEnrolledEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_notifications_mfa_factor_unenrolled_enabled")]
        public bool? MailerNotificationsMfaFactorUnenrolledEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_notifications_identity_linked_enabled")]
        public bool? MailerNotificationsIdentityLinkedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailer_notifications_identity_unlinked_enabled")]
        public bool? MailerNotificationsIdentityUnlinkedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_max_enrolled_factors")]
        public int? MfaMaxEnrolledFactors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_totp_enroll_enabled")]
        public bool? MfaTotpEnrollEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_totp_verify_enabled")]
        public bool? MfaTotpVerifyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_phone_enroll_enabled")]
        public bool? MfaPhoneEnrollEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_phone_verify_enabled")]
        public bool? MfaPhoneVerifyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_web_authn_enroll_enabled")]
        public bool? MfaWebAuthnEnrollEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_web_authn_verify_enabled")]
        public bool? MfaWebAuthnVerifyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passkey_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PasskeyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webauthn_rp_display_name")]
        public string? WebauthnRpDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webauthn_rp_id")]
        public string? WebauthnRpId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webauthn_rp_origins")]
        public string? WebauthnRpOrigins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_phone_otp_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MfaPhoneOtpLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_phone_template")]
        public string? MfaPhoneTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_phone_max_frequency")]
        public int? MfaPhoneMaxFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nimbus_oauth_client_id")]
        public string? NimbusOauthClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nimbus_oauth_email_optional")]
        public bool? NimbusOauthEmailOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nimbus_oauth_client_secret")]
        public string? NimbusOauthClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password_hibp_enabled")]
        public bool? PasswordHibpEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password_min_length")]
        public int? PasswordMinLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password_required_characters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AuthConfigResponsePasswordRequiredCharactersJsonConverter))]
        public global::Supabase.AuthConfigResponsePasswordRequiredCharacters? PasswordRequiredCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_anonymous_users")]
        public int? RateLimitAnonymousUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_email_sent")]
        public int? RateLimitEmailSent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_sms_sent")]
        public int? RateLimitSmsSent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_token_refresh")]
        public int? RateLimitTokenRefresh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_verify")]
        public int? RateLimitVerify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_otp")]
        public int? RateLimitOtp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_web3")]
        public int? RateLimitWeb3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token_rotation_enabled")]
        public bool? RefreshTokenRotationEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_enabled")]
        public bool? SamlEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_external_url")]
        public string? SamlExternalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_allow_encrypted_assertions")]
        public bool? SamlAllowEncryptedAssertions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_sb_forwarded_for_enabled")]
        public bool? SecuritySbForwardedForEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_captcha_enabled")]
        public bool? SecurityCaptchaEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_captcha_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AuthConfigResponseSecurityCaptchaProviderJsonConverter))]
        public global::Supabase.AuthConfigResponseSecurityCaptchaProvider? SecurityCaptchaProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_captcha_secret")]
        public string? SecurityCaptchaSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_manual_linking_enabled")]
        public bool? SecurityManualLinkingEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_refresh_token_reuse_interval")]
        public int? SecurityRefreshTokenReuseInterval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_update_password_require_reauthentication")]
        public bool? SecurityUpdatePasswordRequireReauthentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_inactivity_timeout")]
        public double? SessionsInactivityTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_single_per_user")]
        public bool? SessionsSinglePerUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_tags")]
        public string? SessionsTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_timebox")]
        public double? SessionsTimebox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_url")]
        public string? SiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_autoconfirm")]
        public bool? SmsAutoconfirm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_max_frequency")]
        public int? SmsMaxFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_messagebird_access_key")]
        public string? SmsMessagebirdAccessKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_messagebird_originator")]
        public string? SmsMessagebirdOriginator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_otp_exp")]
        public int? SmsOtpExp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_otp_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SmsOtpLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AuthConfigResponseSmsProviderJsonConverter))]
        public global::Supabase.AuthConfigResponseSmsProvider? SmsProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_template")]
        public string? SmsTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_test_otp")]
        public string? SmsTestOtp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_test_otp_valid_until")]
        public global::System.DateTime? SmsTestOtpValidUntil { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_textlocal_api_key")]
        public string? SmsTextlocalApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_textlocal_sender")]
        public string? SmsTextlocalSender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_twilio_account_sid")]
        public string? SmsTwilioAccountSid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_twilio_auth_token")]
        public string? SmsTwilioAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_twilio_content_sid")]
        public string? SmsTwilioContentSid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_twilio_message_service_sid")]
        public string? SmsTwilioMessageServiceSid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_twilio_verify_account_sid")]
        public string? SmsTwilioVerifyAccountSid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_twilio_verify_auth_token")]
        public string? SmsTwilioVerifyAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_twilio_verify_message_service_sid")]
        public string? SmsTwilioVerifyMessageServiceSid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_vonage_api_key")]
        public string? SmsVonageApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_vonage_api_secret")]
        public string? SmsVonageApiSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_vonage_from")]
        public string? SmsVonageFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtp_admin_email")]
        public string? SmtpAdminEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtp_host")]
        public string? SmtpHost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtp_max_frequency")]
        public int? SmtpMaxFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtp_pass")]
        public string? SmtpPass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtp_port")]
        public string? SmtpPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtp_sender_name")]
        public string? SmtpSenderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smtp_user")]
        public string? SmtpUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri_allow_list")]
        public string? UriAllowList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_server_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OauthServerEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_server_allow_dynamic_registration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OauthServerAllowDynamicRegistration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_server_authorization_path")]
        public string? OauthServerAuthorizationPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_oauth_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CustomOauthEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_oauth_max_providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CustomOauthMaxProviders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConfigResponse" /> class.
        /// </summary>
        /// <param name="mailerOtpExp"></param>
        /// <param name="passkeyEnabled"></param>
        /// <param name="mfaPhoneOtpLength"></param>
        /// <param name="smsOtpLength"></param>
        /// <param name="oauthServerEnabled"></param>
        /// <param name="oauthServerAllowDynamicRegistration"></param>
        /// <param name="customOauthEnabled"></param>
        /// <param name="customOauthMaxProviders"></param>
        /// <param name="apiMaxRequestDuration"></param>
        /// <param name="dbMaxPoolSize"></param>
        /// <param name="dbMaxPoolSizeUnit"></param>
        /// <param name="disableSignup"></param>
        /// <param name="externalAnonymousUsersEnabled"></param>
        /// <param name="externalAppleAdditionalClientIds"></param>
        /// <param name="externalAppleClientId"></param>
        /// <param name="externalAppleEmailOptional"></param>
        /// <param name="externalAppleEnabled"></param>
        /// <param name="externalAppleSecret"></param>
        /// <param name="externalAzureClientId"></param>
        /// <param name="externalAzureEmailOptional"></param>
        /// <param name="externalAzureEnabled"></param>
        /// <param name="externalAzureSecret"></param>
        /// <param name="externalAzureUrl"></param>
        /// <param name="externalBitbucketClientId"></param>
        /// <param name="externalBitbucketEmailOptional"></param>
        /// <param name="externalBitbucketEnabled"></param>
        /// <param name="externalBitbucketSecret"></param>
        /// <param name="externalDiscordClientId"></param>
        /// <param name="externalDiscordEmailOptional"></param>
        /// <param name="externalDiscordEnabled"></param>
        /// <param name="externalDiscordSecret"></param>
        /// <param name="externalEmailEnabled"></param>
        /// <param name="externalFacebookClientId"></param>
        /// <param name="externalFacebookEmailOptional"></param>
        /// <param name="externalFacebookEnabled"></param>
        /// <param name="externalFacebookSecret"></param>
        /// <param name="externalFigmaClientId"></param>
        /// <param name="externalFigmaEmailOptional"></param>
        /// <param name="externalFigmaEnabled"></param>
        /// <param name="externalFigmaSecret"></param>
        /// <param name="externalGithubClientId"></param>
        /// <param name="externalGithubEmailOptional"></param>
        /// <param name="externalGithubEnabled"></param>
        /// <param name="externalGithubSecret"></param>
        /// <param name="externalGitlabClientId"></param>
        /// <param name="externalGitlabEmailOptional"></param>
        /// <param name="externalGitlabEnabled"></param>
        /// <param name="externalGitlabSecret"></param>
        /// <param name="externalGitlabUrl"></param>
        /// <param name="externalGoogleAdditionalClientIds"></param>
        /// <param name="externalGoogleClientId"></param>
        /// <param name="externalGoogleEmailOptional"></param>
        /// <param name="externalGoogleEnabled"></param>
        /// <param name="externalGoogleSecret"></param>
        /// <param name="externalGoogleSkipNonceCheck"></param>
        /// <param name="externalKakaoClientId"></param>
        /// <param name="externalKakaoEmailOptional"></param>
        /// <param name="externalKakaoEnabled"></param>
        /// <param name="externalKakaoSecret"></param>
        /// <param name="externalKeycloakClientId"></param>
        /// <param name="externalKeycloakEmailOptional"></param>
        /// <param name="externalKeycloakEnabled"></param>
        /// <param name="externalKeycloakSecret"></param>
        /// <param name="externalKeycloakUrl"></param>
        /// <param name="externalLinkedinOidcClientId"></param>
        /// <param name="externalLinkedinOidcEmailOptional"></param>
        /// <param name="externalLinkedinOidcEnabled"></param>
        /// <param name="externalLinkedinOidcSecret"></param>
        /// <param name="externalSlackOidcClientId"></param>
        /// <param name="externalSlackOidcEmailOptional"></param>
        /// <param name="externalSlackOidcEnabled"></param>
        /// <param name="externalSlackOidcSecret"></param>
        /// <param name="externalNotionClientId"></param>
        /// <param name="externalNotionEmailOptional"></param>
        /// <param name="externalNotionEnabled"></param>
        /// <param name="externalNotionSecret"></param>
        /// <param name="externalPhoneEnabled"></param>
        /// <param name="externalSlackClientId"></param>
        /// <param name="externalSlackEmailOptional"></param>
        /// <param name="externalSlackEnabled"></param>
        /// <param name="externalSlackSecret"></param>
        /// <param name="externalSpotifyClientId"></param>
        /// <param name="externalSpotifyEmailOptional"></param>
        /// <param name="externalSpotifyEnabled"></param>
        /// <param name="externalSpotifySecret"></param>
        /// <param name="externalTwitchClientId"></param>
        /// <param name="externalTwitchEmailOptional"></param>
        /// <param name="externalTwitchEnabled"></param>
        /// <param name="externalTwitchSecret"></param>
        /// <param name="externalTwitterClientId"></param>
        /// <param name="externalTwitterEmailOptional"></param>
        /// <param name="externalTwitterEnabled"></param>
        /// <param name="externalTwitterSecret"></param>
        /// <param name="externalXClientId"></param>
        /// <param name="externalXEmailOptional"></param>
        /// <param name="externalXEnabled"></param>
        /// <param name="externalXSecret"></param>
        /// <param name="externalWorkosClientId"></param>
        /// <param name="externalWorkosEnabled"></param>
        /// <param name="externalWorkosSecret"></param>
        /// <param name="externalWorkosUrl"></param>
        /// <param name="externalWeb3SolanaEnabled"></param>
        /// <param name="externalWeb3EthereumEnabled"></param>
        /// <param name="externalZoomClientId"></param>
        /// <param name="externalZoomEmailOptional"></param>
        /// <param name="externalZoomEnabled"></param>
        /// <param name="externalZoomSecret"></param>
        /// <param name="hookCustomAccessTokenEnabled"></param>
        /// <param name="hookCustomAccessTokenUri"></param>
        /// <param name="hookCustomAccessTokenSecrets"></param>
        /// <param name="hookMfaVerificationAttemptEnabled"></param>
        /// <param name="hookMfaVerificationAttemptUri"></param>
        /// <param name="hookMfaVerificationAttemptSecrets"></param>
        /// <param name="hookPasswordVerificationAttemptEnabled"></param>
        /// <param name="hookPasswordVerificationAttemptUri"></param>
        /// <param name="hookPasswordVerificationAttemptSecrets"></param>
        /// <param name="hookSendSmsEnabled"></param>
        /// <param name="hookSendSmsUri"></param>
        /// <param name="hookSendSmsSecrets"></param>
        /// <param name="hookSendEmailEnabled"></param>
        /// <param name="hookSendEmailUri"></param>
        /// <param name="hookSendEmailSecrets"></param>
        /// <param name="hookBeforeUserCreatedEnabled"></param>
        /// <param name="hookBeforeUserCreatedUri"></param>
        /// <param name="hookBeforeUserCreatedSecrets"></param>
        /// <param name="hookAfterUserCreatedEnabled"></param>
        /// <param name="hookAfterUserCreatedUri"></param>
        /// <param name="hookAfterUserCreatedSecrets"></param>
        /// <param name="jwtExp"></param>
        /// <param name="mailerAllowUnverifiedEmailSignIns"></param>
        /// <param name="mailerAutoconfirm"></param>
        /// <param name="mailerOtpLength"></param>
        /// <param name="mailerSecureEmailChangeEnabled"></param>
        /// <param name="mailerSubjectsConfirmation"></param>
        /// <param name="mailerSubjectsEmailChange"></param>
        /// <param name="mailerSubjectsInvite"></param>
        /// <param name="mailerSubjectsMagicLink"></param>
        /// <param name="mailerSubjectsReauthentication"></param>
        /// <param name="mailerSubjectsRecovery"></param>
        /// <param name="mailerSubjectsPasswordChangedNotification"></param>
        /// <param name="mailerSubjectsEmailChangedNotification"></param>
        /// <param name="mailerSubjectsPhoneChangedNotification"></param>
        /// <param name="mailerSubjectsMfaFactorEnrolledNotification"></param>
        /// <param name="mailerSubjectsMfaFactorUnenrolledNotification"></param>
        /// <param name="mailerSubjectsIdentityLinkedNotification"></param>
        /// <param name="mailerSubjectsIdentityUnlinkedNotification"></param>
        /// <param name="mailerTemplatesConfirmationContent"></param>
        /// <param name="mailerTemplatesEmailChangeContent"></param>
        /// <param name="mailerTemplatesInviteContent"></param>
        /// <param name="mailerTemplatesMagicLinkContent"></param>
        /// <param name="mailerTemplatesReauthenticationContent"></param>
        /// <param name="mailerTemplatesRecoveryContent"></param>
        /// <param name="mailerTemplatesPasswordChangedNotificationContent"></param>
        /// <param name="mailerTemplatesEmailChangedNotificationContent"></param>
        /// <param name="mailerTemplatesPhoneChangedNotificationContent"></param>
        /// <param name="mailerTemplatesMfaFactorEnrolledNotificationContent"></param>
        /// <param name="mailerTemplatesMfaFactorUnenrolledNotificationContent"></param>
        /// <param name="mailerTemplatesIdentityLinkedNotificationContent"></param>
        /// <param name="mailerTemplatesIdentityUnlinkedNotificationContent"></param>
        /// <param name="mailerNotificationsPasswordChangedEnabled"></param>
        /// <param name="mailerNotificationsEmailChangedEnabled"></param>
        /// <param name="mailerNotificationsPhoneChangedEnabled"></param>
        /// <param name="mailerNotificationsMfaFactorEnrolledEnabled"></param>
        /// <param name="mailerNotificationsMfaFactorUnenrolledEnabled"></param>
        /// <param name="mailerNotificationsIdentityLinkedEnabled"></param>
        /// <param name="mailerNotificationsIdentityUnlinkedEnabled"></param>
        /// <param name="mfaMaxEnrolledFactors"></param>
        /// <param name="mfaTotpEnrollEnabled"></param>
        /// <param name="mfaTotpVerifyEnabled"></param>
        /// <param name="mfaPhoneEnrollEnabled"></param>
        /// <param name="mfaPhoneVerifyEnabled"></param>
        /// <param name="mfaWebAuthnEnrollEnabled"></param>
        /// <param name="mfaWebAuthnVerifyEnabled"></param>
        /// <param name="webauthnRpDisplayName"></param>
        /// <param name="webauthnRpId"></param>
        /// <param name="webauthnRpOrigins"></param>
        /// <param name="mfaPhoneTemplate"></param>
        /// <param name="mfaPhoneMaxFrequency"></param>
        /// <param name="nimbusOauthClientId"></param>
        /// <param name="nimbusOauthEmailOptional"></param>
        /// <param name="nimbusOauthClientSecret"></param>
        /// <param name="passwordHibpEnabled"></param>
        /// <param name="passwordMinLength"></param>
        /// <param name="passwordRequiredCharacters"></param>
        /// <param name="rateLimitAnonymousUsers"></param>
        /// <param name="rateLimitEmailSent"></param>
        /// <param name="rateLimitSmsSent"></param>
        /// <param name="rateLimitTokenRefresh"></param>
        /// <param name="rateLimitVerify"></param>
        /// <param name="rateLimitOtp"></param>
        /// <param name="rateLimitWeb3"></param>
        /// <param name="refreshTokenRotationEnabled"></param>
        /// <param name="samlEnabled"></param>
        /// <param name="samlExternalUrl"></param>
        /// <param name="samlAllowEncryptedAssertions"></param>
        /// <param name="securitySbForwardedForEnabled"></param>
        /// <param name="securityCaptchaEnabled"></param>
        /// <param name="securityCaptchaProvider"></param>
        /// <param name="securityCaptchaSecret"></param>
        /// <param name="securityManualLinkingEnabled"></param>
        /// <param name="securityRefreshTokenReuseInterval"></param>
        /// <param name="securityUpdatePasswordRequireReauthentication"></param>
        /// <param name="sessionsInactivityTimeout"></param>
        /// <param name="sessionsSinglePerUser"></param>
        /// <param name="sessionsTags"></param>
        /// <param name="sessionsTimebox"></param>
        /// <param name="siteUrl"></param>
        /// <param name="smsAutoconfirm"></param>
        /// <param name="smsMaxFrequency"></param>
        /// <param name="smsMessagebirdAccessKey"></param>
        /// <param name="smsMessagebirdOriginator"></param>
        /// <param name="smsOtpExp"></param>
        /// <param name="smsProvider"></param>
        /// <param name="smsTemplate"></param>
        /// <param name="smsTestOtp"></param>
        /// <param name="smsTestOtpValidUntil"></param>
        /// <param name="smsTextlocalApiKey"></param>
        /// <param name="smsTextlocalSender"></param>
        /// <param name="smsTwilioAccountSid"></param>
        /// <param name="smsTwilioAuthToken"></param>
        /// <param name="smsTwilioContentSid"></param>
        /// <param name="smsTwilioMessageServiceSid"></param>
        /// <param name="smsTwilioVerifyAccountSid"></param>
        /// <param name="smsTwilioVerifyAuthToken"></param>
        /// <param name="smsTwilioVerifyMessageServiceSid"></param>
        /// <param name="smsVonageApiKey"></param>
        /// <param name="smsVonageApiSecret"></param>
        /// <param name="smsVonageFrom"></param>
        /// <param name="smtpAdminEmail"></param>
        /// <param name="smtpHost"></param>
        /// <param name="smtpMaxFrequency"></param>
        /// <param name="smtpPass"></param>
        /// <param name="smtpPort"></param>
        /// <param name="smtpSenderName"></param>
        /// <param name="smtpUser"></param>
        /// <param name="uriAllowList"></param>
        /// <param name="oauthServerAuthorizationPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthConfigResponse(
            int mailerOtpExp,
            bool passkeyEnabled,
            int mfaPhoneOtpLength,
            int smsOtpLength,
            bool oauthServerEnabled,
            bool oauthServerAllowDynamicRegistration,
            bool customOauthEnabled,
            int customOauthMaxProviders,
            int? apiMaxRequestDuration,
            int? dbMaxPoolSize,
            global::Supabase.AuthConfigResponseDbMaxPoolSizeUnit? dbMaxPoolSizeUnit,
            bool? disableSignup,
            bool? externalAnonymousUsersEnabled,
            string? externalAppleAdditionalClientIds,
            string? externalAppleClientId,
            bool? externalAppleEmailOptional,
            bool? externalAppleEnabled,
            string? externalAppleSecret,
            string? externalAzureClientId,
            bool? externalAzureEmailOptional,
            bool? externalAzureEnabled,
            string? externalAzureSecret,
            string? externalAzureUrl,
            string? externalBitbucketClientId,
            bool? externalBitbucketEmailOptional,
            bool? externalBitbucketEnabled,
            string? externalBitbucketSecret,
            string? externalDiscordClientId,
            bool? externalDiscordEmailOptional,
            bool? externalDiscordEnabled,
            string? externalDiscordSecret,
            bool? externalEmailEnabled,
            string? externalFacebookClientId,
            bool? externalFacebookEmailOptional,
            bool? externalFacebookEnabled,
            string? externalFacebookSecret,
            string? externalFigmaClientId,
            bool? externalFigmaEmailOptional,
            bool? externalFigmaEnabled,
            string? externalFigmaSecret,
            string? externalGithubClientId,
            bool? externalGithubEmailOptional,
            bool? externalGithubEnabled,
            string? externalGithubSecret,
            string? externalGitlabClientId,
            bool? externalGitlabEmailOptional,
            bool? externalGitlabEnabled,
            string? externalGitlabSecret,
            string? externalGitlabUrl,
            string? externalGoogleAdditionalClientIds,
            string? externalGoogleClientId,
            bool? externalGoogleEmailOptional,
            bool? externalGoogleEnabled,
            string? externalGoogleSecret,
            bool? externalGoogleSkipNonceCheck,
            string? externalKakaoClientId,
            bool? externalKakaoEmailOptional,
            bool? externalKakaoEnabled,
            string? externalKakaoSecret,
            string? externalKeycloakClientId,
            bool? externalKeycloakEmailOptional,
            bool? externalKeycloakEnabled,
            string? externalKeycloakSecret,
            string? externalKeycloakUrl,
            string? externalLinkedinOidcClientId,
            bool? externalLinkedinOidcEmailOptional,
            bool? externalLinkedinOidcEnabled,
            string? externalLinkedinOidcSecret,
            string? externalSlackOidcClientId,
            bool? externalSlackOidcEmailOptional,
            bool? externalSlackOidcEnabled,
            string? externalSlackOidcSecret,
            string? externalNotionClientId,
            bool? externalNotionEmailOptional,
            bool? externalNotionEnabled,
            string? externalNotionSecret,
            bool? externalPhoneEnabled,
            string? externalSlackClientId,
            bool? externalSlackEmailOptional,
            bool? externalSlackEnabled,
            string? externalSlackSecret,
            string? externalSpotifyClientId,
            bool? externalSpotifyEmailOptional,
            bool? externalSpotifyEnabled,
            string? externalSpotifySecret,
            string? externalTwitchClientId,
            bool? externalTwitchEmailOptional,
            bool? externalTwitchEnabled,
            string? externalTwitchSecret,
            string? externalTwitterClientId,
            bool? externalTwitterEmailOptional,
            bool? externalTwitterEnabled,
            string? externalTwitterSecret,
            string? externalXClientId,
            bool? externalXEmailOptional,
            bool? externalXEnabled,
            string? externalXSecret,
            string? externalWorkosClientId,
            bool? externalWorkosEnabled,
            string? externalWorkosSecret,
            string? externalWorkosUrl,
            bool? externalWeb3SolanaEnabled,
            bool? externalWeb3EthereumEnabled,
            string? externalZoomClientId,
            bool? externalZoomEmailOptional,
            bool? externalZoomEnabled,
            string? externalZoomSecret,
            bool? hookCustomAccessTokenEnabled,
            string? hookCustomAccessTokenUri,
            string? hookCustomAccessTokenSecrets,
            bool? hookMfaVerificationAttemptEnabled,
            string? hookMfaVerificationAttemptUri,
            string? hookMfaVerificationAttemptSecrets,
            bool? hookPasswordVerificationAttemptEnabled,
            string? hookPasswordVerificationAttemptUri,
            string? hookPasswordVerificationAttemptSecrets,
            bool? hookSendSmsEnabled,
            string? hookSendSmsUri,
            string? hookSendSmsSecrets,
            bool? hookSendEmailEnabled,
            string? hookSendEmailUri,
            string? hookSendEmailSecrets,
            bool? hookBeforeUserCreatedEnabled,
            string? hookBeforeUserCreatedUri,
            string? hookBeforeUserCreatedSecrets,
            bool? hookAfterUserCreatedEnabled,
            string? hookAfterUserCreatedUri,
            string? hookAfterUserCreatedSecrets,
            int? jwtExp,
            bool? mailerAllowUnverifiedEmailSignIns,
            bool? mailerAutoconfirm,
            int? mailerOtpLength,
            bool? mailerSecureEmailChangeEnabled,
            string? mailerSubjectsConfirmation,
            string? mailerSubjectsEmailChange,
            string? mailerSubjectsInvite,
            string? mailerSubjectsMagicLink,
            string? mailerSubjectsReauthentication,
            string? mailerSubjectsRecovery,
            string? mailerSubjectsPasswordChangedNotification,
            string? mailerSubjectsEmailChangedNotification,
            string? mailerSubjectsPhoneChangedNotification,
            string? mailerSubjectsMfaFactorEnrolledNotification,
            string? mailerSubjectsMfaFactorUnenrolledNotification,
            string? mailerSubjectsIdentityLinkedNotification,
            string? mailerSubjectsIdentityUnlinkedNotification,
            string? mailerTemplatesConfirmationContent,
            string? mailerTemplatesEmailChangeContent,
            string? mailerTemplatesInviteContent,
            string? mailerTemplatesMagicLinkContent,
            string? mailerTemplatesReauthenticationContent,
            string? mailerTemplatesRecoveryContent,
            string? mailerTemplatesPasswordChangedNotificationContent,
            string? mailerTemplatesEmailChangedNotificationContent,
            string? mailerTemplatesPhoneChangedNotificationContent,
            string? mailerTemplatesMfaFactorEnrolledNotificationContent,
            string? mailerTemplatesMfaFactorUnenrolledNotificationContent,
            string? mailerTemplatesIdentityLinkedNotificationContent,
            string? mailerTemplatesIdentityUnlinkedNotificationContent,
            bool? mailerNotificationsPasswordChangedEnabled,
            bool? mailerNotificationsEmailChangedEnabled,
            bool? mailerNotificationsPhoneChangedEnabled,
            bool? mailerNotificationsMfaFactorEnrolledEnabled,
            bool? mailerNotificationsMfaFactorUnenrolledEnabled,
            bool? mailerNotificationsIdentityLinkedEnabled,
            bool? mailerNotificationsIdentityUnlinkedEnabled,
            int? mfaMaxEnrolledFactors,
            bool? mfaTotpEnrollEnabled,
            bool? mfaTotpVerifyEnabled,
            bool? mfaPhoneEnrollEnabled,
            bool? mfaPhoneVerifyEnabled,
            bool? mfaWebAuthnEnrollEnabled,
            bool? mfaWebAuthnVerifyEnabled,
            string? webauthnRpDisplayName,
            string? webauthnRpId,
            string? webauthnRpOrigins,
            string? mfaPhoneTemplate,
            int? mfaPhoneMaxFrequency,
            string? nimbusOauthClientId,
            bool? nimbusOauthEmailOptional,
            string? nimbusOauthClientSecret,
            bool? passwordHibpEnabled,
            int? passwordMinLength,
            global::Supabase.AuthConfigResponsePasswordRequiredCharacters? passwordRequiredCharacters,
            int? rateLimitAnonymousUsers,
            int? rateLimitEmailSent,
            int? rateLimitSmsSent,
            int? rateLimitTokenRefresh,
            int? rateLimitVerify,
            int? rateLimitOtp,
            int? rateLimitWeb3,
            bool? refreshTokenRotationEnabled,
            bool? samlEnabled,
            string? samlExternalUrl,
            bool? samlAllowEncryptedAssertions,
            bool? securitySbForwardedForEnabled,
            bool? securityCaptchaEnabled,
            global::Supabase.AuthConfigResponseSecurityCaptchaProvider? securityCaptchaProvider,
            string? securityCaptchaSecret,
            bool? securityManualLinkingEnabled,
            int? securityRefreshTokenReuseInterval,
            bool? securityUpdatePasswordRequireReauthentication,
            double? sessionsInactivityTimeout,
            bool? sessionsSinglePerUser,
            string? sessionsTags,
            double? sessionsTimebox,
            string? siteUrl,
            bool? smsAutoconfirm,
            int? smsMaxFrequency,
            string? smsMessagebirdAccessKey,
            string? smsMessagebirdOriginator,
            int? smsOtpExp,
            global::Supabase.AuthConfigResponseSmsProvider? smsProvider,
            string? smsTemplate,
            string? smsTestOtp,
            global::System.DateTime? smsTestOtpValidUntil,
            string? smsTextlocalApiKey,
            string? smsTextlocalSender,
            string? smsTwilioAccountSid,
            string? smsTwilioAuthToken,
            string? smsTwilioContentSid,
            string? smsTwilioMessageServiceSid,
            string? smsTwilioVerifyAccountSid,
            string? smsTwilioVerifyAuthToken,
            string? smsTwilioVerifyMessageServiceSid,
            string? smsVonageApiKey,
            string? smsVonageApiSecret,
            string? smsVonageFrom,
            string? smtpAdminEmail,
            string? smtpHost,
            int? smtpMaxFrequency,
            string? smtpPass,
            string? smtpPort,
            string? smtpSenderName,
            string? smtpUser,
            string? uriAllowList,
            string? oauthServerAuthorizationPath)
        {
            this.ApiMaxRequestDuration = apiMaxRequestDuration;
            this.DbMaxPoolSize = dbMaxPoolSize;
            this.DbMaxPoolSizeUnit = dbMaxPoolSizeUnit;
            this.DisableSignup = disableSignup;
            this.ExternalAnonymousUsersEnabled = externalAnonymousUsersEnabled;
            this.ExternalAppleAdditionalClientIds = externalAppleAdditionalClientIds;
            this.ExternalAppleClientId = externalAppleClientId;
            this.ExternalAppleEmailOptional = externalAppleEmailOptional;
            this.ExternalAppleEnabled = externalAppleEnabled;
            this.ExternalAppleSecret = externalAppleSecret;
            this.ExternalAzureClientId = externalAzureClientId;
            this.ExternalAzureEmailOptional = externalAzureEmailOptional;
            this.ExternalAzureEnabled = externalAzureEnabled;
            this.ExternalAzureSecret = externalAzureSecret;
            this.ExternalAzureUrl = externalAzureUrl;
            this.ExternalBitbucketClientId = externalBitbucketClientId;
            this.ExternalBitbucketEmailOptional = externalBitbucketEmailOptional;
            this.ExternalBitbucketEnabled = externalBitbucketEnabled;
            this.ExternalBitbucketSecret = externalBitbucketSecret;
            this.ExternalDiscordClientId = externalDiscordClientId;
            this.ExternalDiscordEmailOptional = externalDiscordEmailOptional;
            this.ExternalDiscordEnabled = externalDiscordEnabled;
            this.ExternalDiscordSecret = externalDiscordSecret;
            this.ExternalEmailEnabled = externalEmailEnabled;
            this.ExternalFacebookClientId = externalFacebookClientId;
            this.ExternalFacebookEmailOptional = externalFacebookEmailOptional;
            this.ExternalFacebookEnabled = externalFacebookEnabled;
            this.ExternalFacebookSecret = externalFacebookSecret;
            this.ExternalFigmaClientId = externalFigmaClientId;
            this.ExternalFigmaEmailOptional = externalFigmaEmailOptional;
            this.ExternalFigmaEnabled = externalFigmaEnabled;
            this.ExternalFigmaSecret = externalFigmaSecret;
            this.ExternalGithubClientId = externalGithubClientId;
            this.ExternalGithubEmailOptional = externalGithubEmailOptional;
            this.ExternalGithubEnabled = externalGithubEnabled;
            this.ExternalGithubSecret = externalGithubSecret;
            this.ExternalGitlabClientId = externalGitlabClientId;
            this.ExternalGitlabEmailOptional = externalGitlabEmailOptional;
            this.ExternalGitlabEnabled = externalGitlabEnabled;
            this.ExternalGitlabSecret = externalGitlabSecret;
            this.ExternalGitlabUrl = externalGitlabUrl;
            this.ExternalGoogleAdditionalClientIds = externalGoogleAdditionalClientIds;
            this.ExternalGoogleClientId = externalGoogleClientId;
            this.ExternalGoogleEmailOptional = externalGoogleEmailOptional;
            this.ExternalGoogleEnabled = externalGoogleEnabled;
            this.ExternalGoogleSecret = externalGoogleSecret;
            this.ExternalGoogleSkipNonceCheck = externalGoogleSkipNonceCheck;
            this.ExternalKakaoClientId = externalKakaoClientId;
            this.ExternalKakaoEmailOptional = externalKakaoEmailOptional;
            this.ExternalKakaoEnabled = externalKakaoEnabled;
            this.ExternalKakaoSecret = externalKakaoSecret;
            this.ExternalKeycloakClientId = externalKeycloakClientId;
            this.ExternalKeycloakEmailOptional = externalKeycloakEmailOptional;
            this.ExternalKeycloakEnabled = externalKeycloakEnabled;
            this.ExternalKeycloakSecret = externalKeycloakSecret;
            this.ExternalKeycloakUrl = externalKeycloakUrl;
            this.ExternalLinkedinOidcClientId = externalLinkedinOidcClientId;
            this.ExternalLinkedinOidcEmailOptional = externalLinkedinOidcEmailOptional;
            this.ExternalLinkedinOidcEnabled = externalLinkedinOidcEnabled;
            this.ExternalLinkedinOidcSecret = externalLinkedinOidcSecret;
            this.ExternalSlackOidcClientId = externalSlackOidcClientId;
            this.ExternalSlackOidcEmailOptional = externalSlackOidcEmailOptional;
            this.ExternalSlackOidcEnabled = externalSlackOidcEnabled;
            this.ExternalSlackOidcSecret = externalSlackOidcSecret;
            this.ExternalNotionClientId = externalNotionClientId;
            this.ExternalNotionEmailOptional = externalNotionEmailOptional;
            this.ExternalNotionEnabled = externalNotionEnabled;
            this.ExternalNotionSecret = externalNotionSecret;
            this.ExternalPhoneEnabled = externalPhoneEnabled;
            this.ExternalSlackClientId = externalSlackClientId;
            this.ExternalSlackEmailOptional = externalSlackEmailOptional;
            this.ExternalSlackEnabled = externalSlackEnabled;
            this.ExternalSlackSecret = externalSlackSecret;
            this.ExternalSpotifyClientId = externalSpotifyClientId;
            this.ExternalSpotifyEmailOptional = externalSpotifyEmailOptional;
            this.ExternalSpotifyEnabled = externalSpotifyEnabled;
            this.ExternalSpotifySecret = externalSpotifySecret;
            this.ExternalTwitchClientId = externalTwitchClientId;
            this.ExternalTwitchEmailOptional = externalTwitchEmailOptional;
            this.ExternalTwitchEnabled = externalTwitchEnabled;
            this.ExternalTwitchSecret = externalTwitchSecret;
            this.ExternalTwitterClientId = externalTwitterClientId;
            this.ExternalTwitterEmailOptional = externalTwitterEmailOptional;
            this.ExternalTwitterEnabled = externalTwitterEnabled;
            this.ExternalTwitterSecret = externalTwitterSecret;
            this.ExternalXClientId = externalXClientId;
            this.ExternalXEmailOptional = externalXEmailOptional;
            this.ExternalXEnabled = externalXEnabled;
            this.ExternalXSecret = externalXSecret;
            this.ExternalWorkosClientId = externalWorkosClientId;
            this.ExternalWorkosEnabled = externalWorkosEnabled;
            this.ExternalWorkosSecret = externalWorkosSecret;
            this.ExternalWorkosUrl = externalWorkosUrl;
            this.ExternalWeb3SolanaEnabled = externalWeb3SolanaEnabled;
            this.ExternalWeb3EthereumEnabled = externalWeb3EthereumEnabled;
            this.ExternalZoomClientId = externalZoomClientId;
            this.ExternalZoomEmailOptional = externalZoomEmailOptional;
            this.ExternalZoomEnabled = externalZoomEnabled;
            this.ExternalZoomSecret = externalZoomSecret;
            this.HookCustomAccessTokenEnabled = hookCustomAccessTokenEnabled;
            this.HookCustomAccessTokenUri = hookCustomAccessTokenUri;
            this.HookCustomAccessTokenSecrets = hookCustomAccessTokenSecrets;
            this.HookMfaVerificationAttemptEnabled = hookMfaVerificationAttemptEnabled;
            this.HookMfaVerificationAttemptUri = hookMfaVerificationAttemptUri;
            this.HookMfaVerificationAttemptSecrets = hookMfaVerificationAttemptSecrets;
            this.HookPasswordVerificationAttemptEnabled = hookPasswordVerificationAttemptEnabled;
            this.HookPasswordVerificationAttemptUri = hookPasswordVerificationAttemptUri;
            this.HookPasswordVerificationAttemptSecrets = hookPasswordVerificationAttemptSecrets;
            this.HookSendSmsEnabled = hookSendSmsEnabled;
            this.HookSendSmsUri = hookSendSmsUri;
            this.HookSendSmsSecrets = hookSendSmsSecrets;
            this.HookSendEmailEnabled = hookSendEmailEnabled;
            this.HookSendEmailUri = hookSendEmailUri;
            this.HookSendEmailSecrets = hookSendEmailSecrets;
            this.HookBeforeUserCreatedEnabled = hookBeforeUserCreatedEnabled;
            this.HookBeforeUserCreatedUri = hookBeforeUserCreatedUri;
            this.HookBeforeUserCreatedSecrets = hookBeforeUserCreatedSecrets;
            this.HookAfterUserCreatedEnabled = hookAfterUserCreatedEnabled;
            this.HookAfterUserCreatedUri = hookAfterUserCreatedUri;
            this.HookAfterUserCreatedSecrets = hookAfterUserCreatedSecrets;
            this.JwtExp = jwtExp;
            this.MailerAllowUnverifiedEmailSignIns = mailerAllowUnverifiedEmailSignIns;
            this.MailerAutoconfirm = mailerAutoconfirm;
            this.MailerOtpExp = mailerOtpExp;
            this.MailerOtpLength = mailerOtpLength;
            this.MailerSecureEmailChangeEnabled = mailerSecureEmailChangeEnabled;
            this.MailerSubjectsConfirmation = mailerSubjectsConfirmation;
            this.MailerSubjectsEmailChange = mailerSubjectsEmailChange;
            this.MailerSubjectsInvite = mailerSubjectsInvite;
            this.MailerSubjectsMagicLink = mailerSubjectsMagicLink;
            this.MailerSubjectsReauthentication = mailerSubjectsReauthentication;
            this.MailerSubjectsRecovery = mailerSubjectsRecovery;
            this.MailerSubjectsPasswordChangedNotification = mailerSubjectsPasswordChangedNotification;
            this.MailerSubjectsEmailChangedNotification = mailerSubjectsEmailChangedNotification;
            this.MailerSubjectsPhoneChangedNotification = mailerSubjectsPhoneChangedNotification;
            this.MailerSubjectsMfaFactorEnrolledNotification = mailerSubjectsMfaFactorEnrolledNotification;
            this.MailerSubjectsMfaFactorUnenrolledNotification = mailerSubjectsMfaFactorUnenrolledNotification;
            this.MailerSubjectsIdentityLinkedNotification = mailerSubjectsIdentityLinkedNotification;
            this.MailerSubjectsIdentityUnlinkedNotification = mailerSubjectsIdentityUnlinkedNotification;
            this.MailerTemplatesConfirmationContent = mailerTemplatesConfirmationContent;
            this.MailerTemplatesEmailChangeContent = mailerTemplatesEmailChangeContent;
            this.MailerTemplatesInviteContent = mailerTemplatesInviteContent;
            this.MailerTemplatesMagicLinkContent = mailerTemplatesMagicLinkContent;
            this.MailerTemplatesReauthenticationContent = mailerTemplatesReauthenticationContent;
            this.MailerTemplatesRecoveryContent = mailerTemplatesRecoveryContent;
            this.MailerTemplatesPasswordChangedNotificationContent = mailerTemplatesPasswordChangedNotificationContent;
            this.MailerTemplatesEmailChangedNotificationContent = mailerTemplatesEmailChangedNotificationContent;
            this.MailerTemplatesPhoneChangedNotificationContent = mailerTemplatesPhoneChangedNotificationContent;
            this.MailerTemplatesMfaFactorEnrolledNotificationContent = mailerTemplatesMfaFactorEnrolledNotificationContent;
            this.MailerTemplatesMfaFactorUnenrolledNotificationContent = mailerTemplatesMfaFactorUnenrolledNotificationContent;
            this.MailerTemplatesIdentityLinkedNotificationContent = mailerTemplatesIdentityLinkedNotificationContent;
            this.MailerTemplatesIdentityUnlinkedNotificationContent = mailerTemplatesIdentityUnlinkedNotificationContent;
            this.MailerNotificationsPasswordChangedEnabled = mailerNotificationsPasswordChangedEnabled;
            this.MailerNotificationsEmailChangedEnabled = mailerNotificationsEmailChangedEnabled;
            this.MailerNotificationsPhoneChangedEnabled = mailerNotificationsPhoneChangedEnabled;
            this.MailerNotificationsMfaFactorEnrolledEnabled = mailerNotificationsMfaFactorEnrolledEnabled;
            this.MailerNotificationsMfaFactorUnenrolledEnabled = mailerNotificationsMfaFactorUnenrolledEnabled;
            this.MailerNotificationsIdentityLinkedEnabled = mailerNotificationsIdentityLinkedEnabled;
            this.MailerNotificationsIdentityUnlinkedEnabled = mailerNotificationsIdentityUnlinkedEnabled;
            this.MfaMaxEnrolledFactors = mfaMaxEnrolledFactors;
            this.MfaTotpEnrollEnabled = mfaTotpEnrollEnabled;
            this.MfaTotpVerifyEnabled = mfaTotpVerifyEnabled;
            this.MfaPhoneEnrollEnabled = mfaPhoneEnrollEnabled;
            this.MfaPhoneVerifyEnabled = mfaPhoneVerifyEnabled;
            this.MfaWebAuthnEnrollEnabled = mfaWebAuthnEnrollEnabled;
            this.MfaWebAuthnVerifyEnabled = mfaWebAuthnVerifyEnabled;
            this.PasskeyEnabled = passkeyEnabled;
            this.WebauthnRpDisplayName = webauthnRpDisplayName;
            this.WebauthnRpId = webauthnRpId;
            this.WebauthnRpOrigins = webauthnRpOrigins;
            this.MfaPhoneOtpLength = mfaPhoneOtpLength;
            this.MfaPhoneTemplate = mfaPhoneTemplate;
            this.MfaPhoneMaxFrequency = mfaPhoneMaxFrequency;
            this.NimbusOauthClientId = nimbusOauthClientId;
            this.NimbusOauthEmailOptional = nimbusOauthEmailOptional;
            this.NimbusOauthClientSecret = nimbusOauthClientSecret;
            this.PasswordHibpEnabled = passwordHibpEnabled;
            this.PasswordMinLength = passwordMinLength;
            this.PasswordRequiredCharacters = passwordRequiredCharacters;
            this.RateLimitAnonymousUsers = rateLimitAnonymousUsers;
            this.RateLimitEmailSent = rateLimitEmailSent;
            this.RateLimitSmsSent = rateLimitSmsSent;
            this.RateLimitTokenRefresh = rateLimitTokenRefresh;
            this.RateLimitVerify = rateLimitVerify;
            this.RateLimitOtp = rateLimitOtp;
            this.RateLimitWeb3 = rateLimitWeb3;
            this.RefreshTokenRotationEnabled = refreshTokenRotationEnabled;
            this.SamlEnabled = samlEnabled;
            this.SamlExternalUrl = samlExternalUrl;
            this.SamlAllowEncryptedAssertions = samlAllowEncryptedAssertions;
            this.SecuritySbForwardedForEnabled = securitySbForwardedForEnabled;
            this.SecurityCaptchaEnabled = securityCaptchaEnabled;
            this.SecurityCaptchaProvider = securityCaptchaProvider;
            this.SecurityCaptchaSecret = securityCaptchaSecret;
            this.SecurityManualLinkingEnabled = securityManualLinkingEnabled;
            this.SecurityRefreshTokenReuseInterval = securityRefreshTokenReuseInterval;
            this.SecurityUpdatePasswordRequireReauthentication = securityUpdatePasswordRequireReauthentication;
            this.SessionsInactivityTimeout = sessionsInactivityTimeout;
            this.SessionsSinglePerUser = sessionsSinglePerUser;
            this.SessionsTags = sessionsTags;
            this.SessionsTimebox = sessionsTimebox;
            this.SiteUrl = siteUrl;
            this.SmsAutoconfirm = smsAutoconfirm;
            this.SmsMaxFrequency = smsMaxFrequency;
            this.SmsMessagebirdAccessKey = smsMessagebirdAccessKey;
            this.SmsMessagebirdOriginator = smsMessagebirdOriginator;
            this.SmsOtpExp = smsOtpExp;
            this.SmsOtpLength = smsOtpLength;
            this.SmsProvider = smsProvider;
            this.SmsTemplate = smsTemplate;
            this.SmsTestOtp = smsTestOtp;
            this.SmsTestOtpValidUntil = smsTestOtpValidUntil;
            this.SmsTextlocalApiKey = smsTextlocalApiKey;
            this.SmsTextlocalSender = smsTextlocalSender;
            this.SmsTwilioAccountSid = smsTwilioAccountSid;
            this.SmsTwilioAuthToken = smsTwilioAuthToken;
            this.SmsTwilioContentSid = smsTwilioContentSid;
            this.SmsTwilioMessageServiceSid = smsTwilioMessageServiceSid;
            this.SmsTwilioVerifyAccountSid = smsTwilioVerifyAccountSid;
            this.SmsTwilioVerifyAuthToken = smsTwilioVerifyAuthToken;
            this.SmsTwilioVerifyMessageServiceSid = smsTwilioVerifyMessageServiceSid;
            this.SmsVonageApiKey = smsVonageApiKey;
            this.SmsVonageApiSecret = smsVonageApiSecret;
            this.SmsVonageFrom = smsVonageFrom;
            this.SmtpAdminEmail = smtpAdminEmail;
            this.SmtpHost = smtpHost;
            this.SmtpMaxFrequency = smtpMaxFrequency;
            this.SmtpPass = smtpPass;
            this.SmtpPort = smtpPort;
            this.SmtpSenderName = smtpSenderName;
            this.SmtpUser = smtpUser;
            this.UriAllowList = uriAllowList;
            this.OauthServerEnabled = oauthServerEnabled;
            this.OauthServerAllowDynamicRegistration = oauthServerAllowDynamicRegistration;
            this.OauthServerAuthorizationPath = oauthServerAuthorizationPath;
            this.CustomOauthEnabled = customOauthEnabled;
            this.CustomOauthMaxProviders = customOauthMaxProviders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConfigResponse" /> class.
        /// </summary>
        public AuthConfigResponse()
        {
        }

    }
}
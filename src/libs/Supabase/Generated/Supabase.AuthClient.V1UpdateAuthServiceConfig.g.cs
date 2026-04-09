
#nullable enable

namespace Supabase
{
    public partial class AuthClient
    {


        private static readonly global::Supabase.EndPointSecurityRequirement s_V1UpdateAuthServiceConfigSecurityRequirement0 =
            new global::Supabase.EndPointSecurityRequirement
            {
                Authorizations = new global::Supabase.EndPointAuthorizationRequirement[]
                {                    new global::Supabase.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Supabase.EndPointSecurityRequirement[] s_V1UpdateAuthServiceConfigSecurityRequirements =
            new global::Supabase.EndPointSecurityRequirement[]
            {                s_V1UpdateAuthServiceConfigSecurityRequirement0,
            };
        partial void PrepareV1UpdateAuthServiceConfigArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @ref,
            global::Supabase.UpdateAuthConfigBody request);
        partial void PrepareV1UpdateAuthServiceConfigRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @ref,
            global::Supabase.UpdateAuthConfigBody request);
        partial void ProcessV1UpdateAuthServiceConfigResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1UpdateAuthServiceConfigResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a project's auth config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Supabase.AuthConfigResponse> V1UpdateAuthServiceConfigAsync(
            string @ref,

            global::Supabase.UpdateAuthConfigBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1UpdateAuthServiceConfigArguments(
                httpClient: HttpClient,
                @ref: ref @ref,
                request: request);


            var __authorizations = global::Supabase.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_V1UpdateAuthServiceConfigSecurityRequirements,
                operationName: "V1UpdateAuthServiceConfigAsync");

            var __pathBuilder = new global::Supabase.PathBuilder(
                path: $"/v1/projects/{@ref}/config/auth",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1UpdateAuthServiceConfigRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @ref: @ref,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1UpdateAuthServiceConfigResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessV1UpdateAuthServiceConfigResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Supabase.AuthConfigResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Supabase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Supabase.AuthConfigResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Supabase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Updates a project's auth config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="siteUrl"></param>
        /// <param name="disableSignup"></param>
        /// <param name="jwtExp"></param>
        /// <param name="smtpAdminEmail"></param>
        /// <param name="smtpHost"></param>
        /// <param name="smtpPort"></param>
        /// <param name="smtpUser"></param>
        /// <param name="smtpPass"></param>
        /// <param name="smtpMaxFrequency"></param>
        /// <param name="smtpSenderName"></param>
        /// <param name="mailerAllowUnverifiedEmailSignIns"></param>
        /// <param name="mailerAutoconfirm"></param>
        /// <param name="mailerSubjectsInvite"></param>
        /// <param name="mailerSubjectsConfirmation"></param>
        /// <param name="mailerSubjectsRecovery"></param>
        /// <param name="mailerSubjectsEmailChange"></param>
        /// <param name="mailerSubjectsMagicLink"></param>
        /// <param name="mailerSubjectsReauthentication"></param>
        /// <param name="mailerSubjectsPasswordChangedNotification"></param>
        /// <param name="mailerSubjectsEmailChangedNotification"></param>
        /// <param name="mailerSubjectsPhoneChangedNotification"></param>
        /// <param name="mailerSubjectsMfaFactorEnrolledNotification"></param>
        /// <param name="mailerSubjectsMfaFactorUnenrolledNotification"></param>
        /// <param name="mailerSubjectsIdentityLinkedNotification"></param>
        /// <param name="mailerSubjectsIdentityUnlinkedNotification"></param>
        /// <param name="mailerTemplatesInviteContent"></param>
        /// <param name="mailerTemplatesConfirmationContent"></param>
        /// <param name="mailerTemplatesRecoveryContent"></param>
        /// <param name="mailerTemplatesEmailChangeContent"></param>
        /// <param name="mailerTemplatesMagicLinkContent"></param>
        /// <param name="mailerTemplatesReauthenticationContent"></param>
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
        /// <param name="uriAllowList"></param>
        /// <param name="externalAnonymousUsersEnabled"></param>
        /// <param name="externalEmailEnabled"></param>
        /// <param name="externalPhoneEnabled"></param>
        /// <param name="samlEnabled"></param>
        /// <param name="samlExternalUrl"></param>
        /// <param name="securitySbForwardedForEnabled"></param>
        /// <param name="securityCaptchaEnabled"></param>
        /// <param name="securityCaptchaProvider"></param>
        /// <param name="securityCaptchaSecret"></param>
        /// <param name="sessionsTimebox"></param>
        /// <param name="sessionsInactivityTimeout"></param>
        /// <param name="sessionsSinglePerUser"></param>
        /// <param name="sessionsTags"></param>
        /// <param name="rateLimitAnonymousUsers"></param>
        /// <param name="rateLimitEmailSent"></param>
        /// <param name="rateLimitSmsSent"></param>
        /// <param name="rateLimitVerify"></param>
        /// <param name="rateLimitTokenRefresh"></param>
        /// <param name="rateLimitOtp"></param>
        /// <param name="rateLimitWeb3"></param>
        /// <param name="mailerSecureEmailChangeEnabled"></param>
        /// <param name="refreshTokenRotationEnabled"></param>
        /// <param name="passwordHibpEnabled"></param>
        /// <param name="passwordMinLength"></param>
        /// <param name="passwordRequiredCharacters"></param>
        /// <param name="securityManualLinkingEnabled"></param>
        /// <param name="securityUpdatePasswordRequireReauthentication"></param>
        /// <param name="securityRefreshTokenReuseInterval"></param>
        /// <param name="mailerOtpExp"></param>
        /// <param name="mailerOtpLength"></param>
        /// <param name="smsAutoconfirm"></param>
        /// <param name="smsMaxFrequency"></param>
        /// <param name="smsOtpExp"></param>
        /// <param name="smsOtpLength"></param>
        /// <param name="smsProvider"></param>
        /// <param name="smsMessagebirdAccessKey"></param>
        /// <param name="smsMessagebirdOriginator"></param>
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
        /// <param name="smsTemplate"></param>
        /// <param name="hookMfaVerificationAttemptEnabled"></param>
        /// <param name="hookMfaVerificationAttemptUri"></param>
        /// <param name="hookMfaVerificationAttemptSecrets"></param>
        /// <param name="hookPasswordVerificationAttemptEnabled"></param>
        /// <param name="hookPasswordVerificationAttemptUri"></param>
        /// <param name="hookPasswordVerificationAttemptSecrets"></param>
        /// <param name="hookCustomAccessTokenEnabled"></param>
        /// <param name="hookCustomAccessTokenUri"></param>
        /// <param name="hookCustomAccessTokenSecrets"></param>
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
        /// <param name="externalAppleEnabled"></param>
        /// <param name="externalAppleClientId"></param>
        /// <param name="externalAppleEmailOptional"></param>
        /// <param name="externalAppleSecret"></param>
        /// <param name="externalAppleAdditionalClientIds"></param>
        /// <param name="externalAzureEnabled"></param>
        /// <param name="externalAzureClientId"></param>
        /// <param name="externalAzureEmailOptional"></param>
        /// <param name="externalAzureSecret"></param>
        /// <param name="externalAzureUrl"></param>
        /// <param name="externalBitbucketEnabled"></param>
        /// <param name="externalBitbucketClientId"></param>
        /// <param name="externalBitbucketEmailOptional"></param>
        /// <param name="externalBitbucketSecret"></param>
        /// <param name="externalDiscordEnabled"></param>
        /// <param name="externalDiscordClientId"></param>
        /// <param name="externalDiscordEmailOptional"></param>
        /// <param name="externalDiscordSecret"></param>
        /// <param name="externalFacebookEnabled"></param>
        /// <param name="externalFacebookClientId"></param>
        /// <param name="externalFacebookEmailOptional"></param>
        /// <param name="externalFacebookSecret"></param>
        /// <param name="externalFigmaEnabled"></param>
        /// <param name="externalFigmaClientId"></param>
        /// <param name="externalFigmaEmailOptional"></param>
        /// <param name="externalFigmaSecret"></param>
        /// <param name="externalGithubEnabled"></param>
        /// <param name="externalGithubClientId"></param>
        /// <param name="externalGithubEmailOptional"></param>
        /// <param name="externalGithubSecret"></param>
        /// <param name="externalGitlabEnabled"></param>
        /// <param name="externalGitlabClientId"></param>
        /// <param name="externalGitlabEmailOptional"></param>
        /// <param name="externalGitlabSecret"></param>
        /// <param name="externalGitlabUrl"></param>
        /// <param name="externalGoogleEnabled"></param>
        /// <param name="externalGoogleClientId"></param>
        /// <param name="externalGoogleEmailOptional"></param>
        /// <param name="externalGoogleSecret"></param>
        /// <param name="externalGoogleAdditionalClientIds"></param>
        /// <param name="externalGoogleSkipNonceCheck"></param>
        /// <param name="externalKakaoEnabled"></param>
        /// <param name="externalKakaoClientId"></param>
        /// <param name="externalKakaoEmailOptional"></param>
        /// <param name="externalKakaoSecret"></param>
        /// <param name="externalKeycloakEnabled"></param>
        /// <param name="externalKeycloakClientId"></param>
        /// <param name="externalKeycloakEmailOptional"></param>
        /// <param name="externalKeycloakSecret"></param>
        /// <param name="externalKeycloakUrl"></param>
        /// <param name="externalLinkedinOidcEnabled"></param>
        /// <param name="externalLinkedinOidcClientId"></param>
        /// <param name="externalLinkedinOidcEmailOptional"></param>
        /// <param name="externalLinkedinOidcSecret"></param>
        /// <param name="externalSlackOidcEnabled"></param>
        /// <param name="externalSlackOidcClientId"></param>
        /// <param name="externalSlackOidcEmailOptional"></param>
        /// <param name="externalSlackOidcSecret"></param>
        /// <param name="externalNotionEnabled"></param>
        /// <param name="externalNotionClientId"></param>
        /// <param name="externalNotionEmailOptional"></param>
        /// <param name="externalNotionSecret"></param>
        /// <param name="externalSlackEnabled"></param>
        /// <param name="externalSlackClientId"></param>
        /// <param name="externalSlackEmailOptional"></param>
        /// <param name="externalSlackSecret"></param>
        /// <param name="externalSpotifyEnabled"></param>
        /// <param name="externalSpotifyClientId"></param>
        /// <param name="externalSpotifyEmailOptional"></param>
        /// <param name="externalSpotifySecret"></param>
        /// <param name="externalTwitchEnabled"></param>
        /// <param name="externalTwitchClientId"></param>
        /// <param name="externalTwitchEmailOptional"></param>
        /// <param name="externalTwitchSecret"></param>
        /// <param name="externalTwitterEnabled"></param>
        /// <param name="externalTwitterClientId"></param>
        /// <param name="externalTwitterEmailOptional"></param>
        /// <param name="externalTwitterSecret"></param>
        /// <param name="externalXEnabled"></param>
        /// <param name="externalXClientId"></param>
        /// <param name="externalXEmailOptional"></param>
        /// <param name="externalXSecret"></param>
        /// <param name="externalWorkosEnabled"></param>
        /// <param name="externalWorkosClientId"></param>
        /// <param name="externalWorkosSecret"></param>
        /// <param name="externalWorkosUrl"></param>
        /// <param name="externalWeb3SolanaEnabled"></param>
        /// <param name="externalWeb3EthereumEnabled"></param>
        /// <param name="externalZoomEnabled"></param>
        /// <param name="externalZoomClientId"></param>
        /// <param name="externalZoomEmailOptional"></param>
        /// <param name="externalZoomSecret"></param>
        /// <param name="dbMaxPoolSize"></param>
        /// <param name="dbMaxPoolSizeUnit"></param>
        /// <param name="apiMaxRequestDuration"></param>
        /// <param name="mfaTotpEnrollEnabled"></param>
        /// <param name="mfaTotpVerifyEnabled"></param>
        /// <param name="mfaWebAuthnEnrollEnabled"></param>
        /// <param name="mfaWebAuthnVerifyEnabled"></param>
        /// <param name="passkeyEnabled"></param>
        /// <param name="webauthnRpDisplayName"></param>
        /// <param name="webauthnRpId"></param>
        /// <param name="webauthnRpOrigins"></param>
        /// <param name="mfaPhoneEnrollEnabled"></param>
        /// <param name="mfaPhoneVerifyEnabled"></param>
        /// <param name="mfaPhoneMaxFrequency"></param>
        /// <param name="mfaPhoneOtpLength"></param>
        /// <param name="mfaPhoneTemplate"></param>
        /// <param name="nimbusOauthClientId"></param>
        /// <param name="nimbusOauthClientSecret"></param>
        /// <param name="oauthServerEnabled"></param>
        /// <param name="oauthServerAllowDynamicRegistration"></param>
        /// <param name="oauthServerAuthorizationPath"></param>
        /// <param name="customOauthEnabled"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Supabase.AuthConfigResponse> V1UpdateAuthServiceConfigAsync(
            string @ref,
            string? siteUrl = default,
            bool? disableSignup = default,
            int? jwtExp = default,
            string? smtpAdminEmail = default,
            string? smtpHost = default,
            string? smtpPort = default,
            string? smtpUser = default,
            string? smtpPass = default,
            int? smtpMaxFrequency = default,
            string? smtpSenderName = default,
            bool? mailerAllowUnverifiedEmailSignIns = default,
            bool? mailerAutoconfirm = default,
            string? mailerSubjectsInvite = default,
            string? mailerSubjectsConfirmation = default,
            string? mailerSubjectsRecovery = default,
            string? mailerSubjectsEmailChange = default,
            string? mailerSubjectsMagicLink = default,
            string? mailerSubjectsReauthentication = default,
            string? mailerSubjectsPasswordChangedNotification = default,
            string? mailerSubjectsEmailChangedNotification = default,
            string? mailerSubjectsPhoneChangedNotification = default,
            string? mailerSubjectsMfaFactorEnrolledNotification = default,
            string? mailerSubjectsMfaFactorUnenrolledNotification = default,
            string? mailerSubjectsIdentityLinkedNotification = default,
            string? mailerSubjectsIdentityUnlinkedNotification = default,
            string? mailerTemplatesInviteContent = default,
            string? mailerTemplatesConfirmationContent = default,
            string? mailerTemplatesRecoveryContent = default,
            string? mailerTemplatesEmailChangeContent = default,
            string? mailerTemplatesMagicLinkContent = default,
            string? mailerTemplatesReauthenticationContent = default,
            string? mailerTemplatesPasswordChangedNotificationContent = default,
            string? mailerTemplatesEmailChangedNotificationContent = default,
            string? mailerTemplatesPhoneChangedNotificationContent = default,
            string? mailerTemplatesMfaFactorEnrolledNotificationContent = default,
            string? mailerTemplatesMfaFactorUnenrolledNotificationContent = default,
            string? mailerTemplatesIdentityLinkedNotificationContent = default,
            string? mailerTemplatesIdentityUnlinkedNotificationContent = default,
            bool? mailerNotificationsPasswordChangedEnabled = default,
            bool? mailerNotificationsEmailChangedEnabled = default,
            bool? mailerNotificationsPhoneChangedEnabled = default,
            bool? mailerNotificationsMfaFactorEnrolledEnabled = default,
            bool? mailerNotificationsMfaFactorUnenrolledEnabled = default,
            bool? mailerNotificationsIdentityLinkedEnabled = default,
            bool? mailerNotificationsIdentityUnlinkedEnabled = default,
            int? mfaMaxEnrolledFactors = default,
            string? uriAllowList = default,
            bool? externalAnonymousUsersEnabled = default,
            bool? externalEmailEnabled = default,
            bool? externalPhoneEnabled = default,
            bool? samlEnabled = default,
            string? samlExternalUrl = default,
            bool? securitySbForwardedForEnabled = default,
            bool? securityCaptchaEnabled = default,
            global::Supabase.UpdateAuthConfigBodySecurityCaptchaProvider? securityCaptchaProvider = default,
            string? securityCaptchaSecret = default,
            double? sessionsTimebox = default,
            double? sessionsInactivityTimeout = default,
            bool? sessionsSinglePerUser = default,
            string? sessionsTags = default,
            int? rateLimitAnonymousUsers = default,
            int? rateLimitEmailSent = default,
            int? rateLimitSmsSent = default,
            int? rateLimitVerify = default,
            int? rateLimitTokenRefresh = default,
            int? rateLimitOtp = default,
            int? rateLimitWeb3 = default,
            bool? mailerSecureEmailChangeEnabled = default,
            bool? refreshTokenRotationEnabled = default,
            bool? passwordHibpEnabled = default,
            int? passwordMinLength = default,
            global::Supabase.UpdateAuthConfigBodyPasswordRequiredCharacters? passwordRequiredCharacters = default,
            bool? securityManualLinkingEnabled = default,
            bool? securityUpdatePasswordRequireReauthentication = default,
            int? securityRefreshTokenReuseInterval = default,
            int? mailerOtpExp = default,
            int? mailerOtpLength = default,
            bool? smsAutoconfirm = default,
            int? smsMaxFrequency = default,
            int? smsOtpExp = default,
            int? smsOtpLength = default,
            global::Supabase.UpdateAuthConfigBodySmsProvider? smsProvider = default,
            string? smsMessagebirdAccessKey = default,
            string? smsMessagebirdOriginator = default,
            string? smsTestOtp = default,
            global::System.DateTime? smsTestOtpValidUntil = default,
            string? smsTextlocalApiKey = default,
            string? smsTextlocalSender = default,
            string? smsTwilioAccountSid = default,
            string? smsTwilioAuthToken = default,
            string? smsTwilioContentSid = default,
            string? smsTwilioMessageServiceSid = default,
            string? smsTwilioVerifyAccountSid = default,
            string? smsTwilioVerifyAuthToken = default,
            string? smsTwilioVerifyMessageServiceSid = default,
            string? smsVonageApiKey = default,
            string? smsVonageApiSecret = default,
            string? smsVonageFrom = default,
            string? smsTemplate = default,
            bool? hookMfaVerificationAttemptEnabled = default,
            string? hookMfaVerificationAttemptUri = default,
            string? hookMfaVerificationAttemptSecrets = default,
            bool? hookPasswordVerificationAttemptEnabled = default,
            string? hookPasswordVerificationAttemptUri = default,
            string? hookPasswordVerificationAttemptSecrets = default,
            bool? hookCustomAccessTokenEnabled = default,
            string? hookCustomAccessTokenUri = default,
            string? hookCustomAccessTokenSecrets = default,
            bool? hookSendSmsEnabled = default,
            string? hookSendSmsUri = default,
            string? hookSendSmsSecrets = default,
            bool? hookSendEmailEnabled = default,
            string? hookSendEmailUri = default,
            string? hookSendEmailSecrets = default,
            bool? hookBeforeUserCreatedEnabled = default,
            string? hookBeforeUserCreatedUri = default,
            string? hookBeforeUserCreatedSecrets = default,
            bool? hookAfterUserCreatedEnabled = default,
            string? hookAfterUserCreatedUri = default,
            string? hookAfterUserCreatedSecrets = default,
            bool? externalAppleEnabled = default,
            string? externalAppleClientId = default,
            bool? externalAppleEmailOptional = default,
            string? externalAppleSecret = default,
            string? externalAppleAdditionalClientIds = default,
            bool? externalAzureEnabled = default,
            string? externalAzureClientId = default,
            bool? externalAzureEmailOptional = default,
            string? externalAzureSecret = default,
            string? externalAzureUrl = default,
            bool? externalBitbucketEnabled = default,
            string? externalBitbucketClientId = default,
            bool? externalBitbucketEmailOptional = default,
            string? externalBitbucketSecret = default,
            bool? externalDiscordEnabled = default,
            string? externalDiscordClientId = default,
            bool? externalDiscordEmailOptional = default,
            string? externalDiscordSecret = default,
            bool? externalFacebookEnabled = default,
            string? externalFacebookClientId = default,
            bool? externalFacebookEmailOptional = default,
            string? externalFacebookSecret = default,
            bool? externalFigmaEnabled = default,
            string? externalFigmaClientId = default,
            bool? externalFigmaEmailOptional = default,
            string? externalFigmaSecret = default,
            bool? externalGithubEnabled = default,
            string? externalGithubClientId = default,
            bool? externalGithubEmailOptional = default,
            string? externalGithubSecret = default,
            bool? externalGitlabEnabled = default,
            string? externalGitlabClientId = default,
            bool? externalGitlabEmailOptional = default,
            string? externalGitlabSecret = default,
            string? externalGitlabUrl = default,
            bool? externalGoogleEnabled = default,
            string? externalGoogleClientId = default,
            bool? externalGoogleEmailOptional = default,
            string? externalGoogleSecret = default,
            string? externalGoogleAdditionalClientIds = default,
            bool? externalGoogleSkipNonceCheck = default,
            bool? externalKakaoEnabled = default,
            string? externalKakaoClientId = default,
            bool? externalKakaoEmailOptional = default,
            string? externalKakaoSecret = default,
            bool? externalKeycloakEnabled = default,
            string? externalKeycloakClientId = default,
            bool? externalKeycloakEmailOptional = default,
            string? externalKeycloakSecret = default,
            string? externalKeycloakUrl = default,
            bool? externalLinkedinOidcEnabled = default,
            string? externalLinkedinOidcClientId = default,
            bool? externalLinkedinOidcEmailOptional = default,
            string? externalLinkedinOidcSecret = default,
            bool? externalSlackOidcEnabled = default,
            string? externalSlackOidcClientId = default,
            bool? externalSlackOidcEmailOptional = default,
            string? externalSlackOidcSecret = default,
            bool? externalNotionEnabled = default,
            string? externalNotionClientId = default,
            bool? externalNotionEmailOptional = default,
            string? externalNotionSecret = default,
            bool? externalSlackEnabled = default,
            string? externalSlackClientId = default,
            bool? externalSlackEmailOptional = default,
            string? externalSlackSecret = default,
            bool? externalSpotifyEnabled = default,
            string? externalSpotifyClientId = default,
            bool? externalSpotifyEmailOptional = default,
            string? externalSpotifySecret = default,
            bool? externalTwitchEnabled = default,
            string? externalTwitchClientId = default,
            bool? externalTwitchEmailOptional = default,
            string? externalTwitchSecret = default,
            bool? externalTwitterEnabled = default,
            string? externalTwitterClientId = default,
            bool? externalTwitterEmailOptional = default,
            string? externalTwitterSecret = default,
            bool? externalXEnabled = default,
            string? externalXClientId = default,
            bool? externalXEmailOptional = default,
            string? externalXSecret = default,
            bool? externalWorkosEnabled = default,
            string? externalWorkosClientId = default,
            string? externalWorkosSecret = default,
            string? externalWorkosUrl = default,
            bool? externalWeb3SolanaEnabled = default,
            bool? externalWeb3EthereumEnabled = default,
            bool? externalZoomEnabled = default,
            string? externalZoomClientId = default,
            bool? externalZoomEmailOptional = default,
            string? externalZoomSecret = default,
            int? dbMaxPoolSize = default,
            global::Supabase.UpdateAuthConfigBodyDbMaxPoolSizeUnit? dbMaxPoolSizeUnit = default,
            int? apiMaxRequestDuration = default,
            bool? mfaTotpEnrollEnabled = default,
            bool? mfaTotpVerifyEnabled = default,
            bool? mfaWebAuthnEnrollEnabled = default,
            bool? mfaWebAuthnVerifyEnabled = default,
            bool? passkeyEnabled = default,
            string? webauthnRpDisplayName = default,
            string? webauthnRpId = default,
            string? webauthnRpOrigins = default,
            bool? mfaPhoneEnrollEnabled = default,
            bool? mfaPhoneVerifyEnabled = default,
            int? mfaPhoneMaxFrequency = default,
            int? mfaPhoneOtpLength = default,
            string? mfaPhoneTemplate = default,
            string? nimbusOauthClientId = default,
            string? nimbusOauthClientSecret = default,
            bool? oauthServerEnabled = default,
            bool? oauthServerAllowDynamicRegistration = default,
            string? oauthServerAuthorizationPath = default,
            bool? customOauthEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Supabase.UpdateAuthConfigBody
            {
                SiteUrl = siteUrl,
                DisableSignup = disableSignup,
                JwtExp = jwtExp,
                SmtpAdminEmail = smtpAdminEmail,
                SmtpHost = smtpHost,
                SmtpPort = smtpPort,
                SmtpUser = smtpUser,
                SmtpPass = smtpPass,
                SmtpMaxFrequency = smtpMaxFrequency,
                SmtpSenderName = smtpSenderName,
                MailerAllowUnverifiedEmailSignIns = mailerAllowUnverifiedEmailSignIns,
                MailerAutoconfirm = mailerAutoconfirm,
                MailerSubjectsInvite = mailerSubjectsInvite,
                MailerSubjectsConfirmation = mailerSubjectsConfirmation,
                MailerSubjectsRecovery = mailerSubjectsRecovery,
                MailerSubjectsEmailChange = mailerSubjectsEmailChange,
                MailerSubjectsMagicLink = mailerSubjectsMagicLink,
                MailerSubjectsReauthentication = mailerSubjectsReauthentication,
                MailerSubjectsPasswordChangedNotification = mailerSubjectsPasswordChangedNotification,
                MailerSubjectsEmailChangedNotification = mailerSubjectsEmailChangedNotification,
                MailerSubjectsPhoneChangedNotification = mailerSubjectsPhoneChangedNotification,
                MailerSubjectsMfaFactorEnrolledNotification = mailerSubjectsMfaFactorEnrolledNotification,
                MailerSubjectsMfaFactorUnenrolledNotification = mailerSubjectsMfaFactorUnenrolledNotification,
                MailerSubjectsIdentityLinkedNotification = mailerSubjectsIdentityLinkedNotification,
                MailerSubjectsIdentityUnlinkedNotification = mailerSubjectsIdentityUnlinkedNotification,
                MailerTemplatesInviteContent = mailerTemplatesInviteContent,
                MailerTemplatesConfirmationContent = mailerTemplatesConfirmationContent,
                MailerTemplatesRecoveryContent = mailerTemplatesRecoveryContent,
                MailerTemplatesEmailChangeContent = mailerTemplatesEmailChangeContent,
                MailerTemplatesMagicLinkContent = mailerTemplatesMagicLinkContent,
                MailerTemplatesReauthenticationContent = mailerTemplatesReauthenticationContent,
                MailerTemplatesPasswordChangedNotificationContent = mailerTemplatesPasswordChangedNotificationContent,
                MailerTemplatesEmailChangedNotificationContent = mailerTemplatesEmailChangedNotificationContent,
                MailerTemplatesPhoneChangedNotificationContent = mailerTemplatesPhoneChangedNotificationContent,
                MailerTemplatesMfaFactorEnrolledNotificationContent = mailerTemplatesMfaFactorEnrolledNotificationContent,
                MailerTemplatesMfaFactorUnenrolledNotificationContent = mailerTemplatesMfaFactorUnenrolledNotificationContent,
                MailerTemplatesIdentityLinkedNotificationContent = mailerTemplatesIdentityLinkedNotificationContent,
                MailerTemplatesIdentityUnlinkedNotificationContent = mailerTemplatesIdentityUnlinkedNotificationContent,
                MailerNotificationsPasswordChangedEnabled = mailerNotificationsPasswordChangedEnabled,
                MailerNotificationsEmailChangedEnabled = mailerNotificationsEmailChangedEnabled,
                MailerNotificationsPhoneChangedEnabled = mailerNotificationsPhoneChangedEnabled,
                MailerNotificationsMfaFactorEnrolledEnabled = mailerNotificationsMfaFactorEnrolledEnabled,
                MailerNotificationsMfaFactorUnenrolledEnabled = mailerNotificationsMfaFactorUnenrolledEnabled,
                MailerNotificationsIdentityLinkedEnabled = mailerNotificationsIdentityLinkedEnabled,
                MailerNotificationsIdentityUnlinkedEnabled = mailerNotificationsIdentityUnlinkedEnabled,
                MfaMaxEnrolledFactors = mfaMaxEnrolledFactors,
                UriAllowList = uriAllowList,
                ExternalAnonymousUsersEnabled = externalAnonymousUsersEnabled,
                ExternalEmailEnabled = externalEmailEnabled,
                ExternalPhoneEnabled = externalPhoneEnabled,
                SamlEnabled = samlEnabled,
                SamlExternalUrl = samlExternalUrl,
                SecuritySbForwardedForEnabled = securitySbForwardedForEnabled,
                SecurityCaptchaEnabled = securityCaptchaEnabled,
                SecurityCaptchaProvider = securityCaptchaProvider,
                SecurityCaptchaSecret = securityCaptchaSecret,
                SessionsTimebox = sessionsTimebox,
                SessionsInactivityTimeout = sessionsInactivityTimeout,
                SessionsSinglePerUser = sessionsSinglePerUser,
                SessionsTags = sessionsTags,
                RateLimitAnonymousUsers = rateLimitAnonymousUsers,
                RateLimitEmailSent = rateLimitEmailSent,
                RateLimitSmsSent = rateLimitSmsSent,
                RateLimitVerify = rateLimitVerify,
                RateLimitTokenRefresh = rateLimitTokenRefresh,
                RateLimitOtp = rateLimitOtp,
                RateLimitWeb3 = rateLimitWeb3,
                MailerSecureEmailChangeEnabled = mailerSecureEmailChangeEnabled,
                RefreshTokenRotationEnabled = refreshTokenRotationEnabled,
                PasswordHibpEnabled = passwordHibpEnabled,
                PasswordMinLength = passwordMinLength,
                PasswordRequiredCharacters = passwordRequiredCharacters,
                SecurityManualLinkingEnabled = securityManualLinkingEnabled,
                SecurityUpdatePasswordRequireReauthentication = securityUpdatePasswordRequireReauthentication,
                SecurityRefreshTokenReuseInterval = securityRefreshTokenReuseInterval,
                MailerOtpExp = mailerOtpExp,
                MailerOtpLength = mailerOtpLength,
                SmsAutoconfirm = smsAutoconfirm,
                SmsMaxFrequency = smsMaxFrequency,
                SmsOtpExp = smsOtpExp,
                SmsOtpLength = smsOtpLength,
                SmsProvider = smsProvider,
                SmsMessagebirdAccessKey = smsMessagebirdAccessKey,
                SmsMessagebirdOriginator = smsMessagebirdOriginator,
                SmsTestOtp = smsTestOtp,
                SmsTestOtpValidUntil = smsTestOtpValidUntil,
                SmsTextlocalApiKey = smsTextlocalApiKey,
                SmsTextlocalSender = smsTextlocalSender,
                SmsTwilioAccountSid = smsTwilioAccountSid,
                SmsTwilioAuthToken = smsTwilioAuthToken,
                SmsTwilioContentSid = smsTwilioContentSid,
                SmsTwilioMessageServiceSid = smsTwilioMessageServiceSid,
                SmsTwilioVerifyAccountSid = smsTwilioVerifyAccountSid,
                SmsTwilioVerifyAuthToken = smsTwilioVerifyAuthToken,
                SmsTwilioVerifyMessageServiceSid = smsTwilioVerifyMessageServiceSid,
                SmsVonageApiKey = smsVonageApiKey,
                SmsVonageApiSecret = smsVonageApiSecret,
                SmsVonageFrom = smsVonageFrom,
                SmsTemplate = smsTemplate,
                HookMfaVerificationAttemptEnabled = hookMfaVerificationAttemptEnabled,
                HookMfaVerificationAttemptUri = hookMfaVerificationAttemptUri,
                HookMfaVerificationAttemptSecrets = hookMfaVerificationAttemptSecrets,
                HookPasswordVerificationAttemptEnabled = hookPasswordVerificationAttemptEnabled,
                HookPasswordVerificationAttemptUri = hookPasswordVerificationAttemptUri,
                HookPasswordVerificationAttemptSecrets = hookPasswordVerificationAttemptSecrets,
                HookCustomAccessTokenEnabled = hookCustomAccessTokenEnabled,
                HookCustomAccessTokenUri = hookCustomAccessTokenUri,
                HookCustomAccessTokenSecrets = hookCustomAccessTokenSecrets,
                HookSendSmsEnabled = hookSendSmsEnabled,
                HookSendSmsUri = hookSendSmsUri,
                HookSendSmsSecrets = hookSendSmsSecrets,
                HookSendEmailEnabled = hookSendEmailEnabled,
                HookSendEmailUri = hookSendEmailUri,
                HookSendEmailSecrets = hookSendEmailSecrets,
                HookBeforeUserCreatedEnabled = hookBeforeUserCreatedEnabled,
                HookBeforeUserCreatedUri = hookBeforeUserCreatedUri,
                HookBeforeUserCreatedSecrets = hookBeforeUserCreatedSecrets,
                HookAfterUserCreatedEnabled = hookAfterUserCreatedEnabled,
                HookAfterUserCreatedUri = hookAfterUserCreatedUri,
                HookAfterUserCreatedSecrets = hookAfterUserCreatedSecrets,
                ExternalAppleEnabled = externalAppleEnabled,
                ExternalAppleClientId = externalAppleClientId,
                ExternalAppleEmailOptional = externalAppleEmailOptional,
                ExternalAppleSecret = externalAppleSecret,
                ExternalAppleAdditionalClientIds = externalAppleAdditionalClientIds,
                ExternalAzureEnabled = externalAzureEnabled,
                ExternalAzureClientId = externalAzureClientId,
                ExternalAzureEmailOptional = externalAzureEmailOptional,
                ExternalAzureSecret = externalAzureSecret,
                ExternalAzureUrl = externalAzureUrl,
                ExternalBitbucketEnabled = externalBitbucketEnabled,
                ExternalBitbucketClientId = externalBitbucketClientId,
                ExternalBitbucketEmailOptional = externalBitbucketEmailOptional,
                ExternalBitbucketSecret = externalBitbucketSecret,
                ExternalDiscordEnabled = externalDiscordEnabled,
                ExternalDiscordClientId = externalDiscordClientId,
                ExternalDiscordEmailOptional = externalDiscordEmailOptional,
                ExternalDiscordSecret = externalDiscordSecret,
                ExternalFacebookEnabled = externalFacebookEnabled,
                ExternalFacebookClientId = externalFacebookClientId,
                ExternalFacebookEmailOptional = externalFacebookEmailOptional,
                ExternalFacebookSecret = externalFacebookSecret,
                ExternalFigmaEnabled = externalFigmaEnabled,
                ExternalFigmaClientId = externalFigmaClientId,
                ExternalFigmaEmailOptional = externalFigmaEmailOptional,
                ExternalFigmaSecret = externalFigmaSecret,
                ExternalGithubEnabled = externalGithubEnabled,
                ExternalGithubClientId = externalGithubClientId,
                ExternalGithubEmailOptional = externalGithubEmailOptional,
                ExternalGithubSecret = externalGithubSecret,
                ExternalGitlabEnabled = externalGitlabEnabled,
                ExternalGitlabClientId = externalGitlabClientId,
                ExternalGitlabEmailOptional = externalGitlabEmailOptional,
                ExternalGitlabSecret = externalGitlabSecret,
                ExternalGitlabUrl = externalGitlabUrl,
                ExternalGoogleEnabled = externalGoogleEnabled,
                ExternalGoogleClientId = externalGoogleClientId,
                ExternalGoogleEmailOptional = externalGoogleEmailOptional,
                ExternalGoogleSecret = externalGoogleSecret,
                ExternalGoogleAdditionalClientIds = externalGoogleAdditionalClientIds,
                ExternalGoogleSkipNonceCheck = externalGoogleSkipNonceCheck,
                ExternalKakaoEnabled = externalKakaoEnabled,
                ExternalKakaoClientId = externalKakaoClientId,
                ExternalKakaoEmailOptional = externalKakaoEmailOptional,
                ExternalKakaoSecret = externalKakaoSecret,
                ExternalKeycloakEnabled = externalKeycloakEnabled,
                ExternalKeycloakClientId = externalKeycloakClientId,
                ExternalKeycloakEmailOptional = externalKeycloakEmailOptional,
                ExternalKeycloakSecret = externalKeycloakSecret,
                ExternalKeycloakUrl = externalKeycloakUrl,
                ExternalLinkedinOidcEnabled = externalLinkedinOidcEnabled,
                ExternalLinkedinOidcClientId = externalLinkedinOidcClientId,
                ExternalLinkedinOidcEmailOptional = externalLinkedinOidcEmailOptional,
                ExternalLinkedinOidcSecret = externalLinkedinOidcSecret,
                ExternalSlackOidcEnabled = externalSlackOidcEnabled,
                ExternalSlackOidcClientId = externalSlackOidcClientId,
                ExternalSlackOidcEmailOptional = externalSlackOidcEmailOptional,
                ExternalSlackOidcSecret = externalSlackOidcSecret,
                ExternalNotionEnabled = externalNotionEnabled,
                ExternalNotionClientId = externalNotionClientId,
                ExternalNotionEmailOptional = externalNotionEmailOptional,
                ExternalNotionSecret = externalNotionSecret,
                ExternalSlackEnabled = externalSlackEnabled,
                ExternalSlackClientId = externalSlackClientId,
                ExternalSlackEmailOptional = externalSlackEmailOptional,
                ExternalSlackSecret = externalSlackSecret,
                ExternalSpotifyEnabled = externalSpotifyEnabled,
                ExternalSpotifyClientId = externalSpotifyClientId,
                ExternalSpotifyEmailOptional = externalSpotifyEmailOptional,
                ExternalSpotifySecret = externalSpotifySecret,
                ExternalTwitchEnabled = externalTwitchEnabled,
                ExternalTwitchClientId = externalTwitchClientId,
                ExternalTwitchEmailOptional = externalTwitchEmailOptional,
                ExternalTwitchSecret = externalTwitchSecret,
                ExternalTwitterEnabled = externalTwitterEnabled,
                ExternalTwitterClientId = externalTwitterClientId,
                ExternalTwitterEmailOptional = externalTwitterEmailOptional,
                ExternalTwitterSecret = externalTwitterSecret,
                ExternalXEnabled = externalXEnabled,
                ExternalXClientId = externalXClientId,
                ExternalXEmailOptional = externalXEmailOptional,
                ExternalXSecret = externalXSecret,
                ExternalWorkosEnabled = externalWorkosEnabled,
                ExternalWorkosClientId = externalWorkosClientId,
                ExternalWorkosSecret = externalWorkosSecret,
                ExternalWorkosUrl = externalWorkosUrl,
                ExternalWeb3SolanaEnabled = externalWeb3SolanaEnabled,
                ExternalWeb3EthereumEnabled = externalWeb3EthereumEnabled,
                ExternalZoomEnabled = externalZoomEnabled,
                ExternalZoomClientId = externalZoomClientId,
                ExternalZoomEmailOptional = externalZoomEmailOptional,
                ExternalZoomSecret = externalZoomSecret,
                DbMaxPoolSize = dbMaxPoolSize,
                DbMaxPoolSizeUnit = dbMaxPoolSizeUnit,
                ApiMaxRequestDuration = apiMaxRequestDuration,
                MfaTotpEnrollEnabled = mfaTotpEnrollEnabled,
                MfaTotpVerifyEnabled = mfaTotpVerifyEnabled,
                MfaWebAuthnEnrollEnabled = mfaWebAuthnEnrollEnabled,
                MfaWebAuthnVerifyEnabled = mfaWebAuthnVerifyEnabled,
                PasskeyEnabled = passkeyEnabled,
                WebauthnRpDisplayName = webauthnRpDisplayName,
                WebauthnRpId = webauthnRpId,
                WebauthnRpOrigins = webauthnRpOrigins,
                MfaPhoneEnrollEnabled = mfaPhoneEnrollEnabled,
                MfaPhoneVerifyEnabled = mfaPhoneVerifyEnabled,
                MfaPhoneMaxFrequency = mfaPhoneMaxFrequency,
                MfaPhoneOtpLength = mfaPhoneOtpLength,
                MfaPhoneTemplate = mfaPhoneTemplate,
                NimbusOauthClientId = nimbusOauthClientId,
                NimbusOauthClientSecret = nimbusOauthClientSecret,
                OauthServerEnabled = oauthServerEnabled,
                OauthServerAllowDynamicRegistration = oauthServerAllowDynamicRegistration,
                OauthServerAuthorizationPath = oauthServerAuthorizationPath,
                CustomOauthEnabled = customOauthEnabled,
            };

            return await V1UpdateAuthServiceConfigAsync(
                @ref: @ref,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
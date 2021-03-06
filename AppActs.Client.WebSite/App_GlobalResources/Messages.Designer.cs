//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Messages", global::System.Reflection.Assembly.Load("App_GlobalResources"));
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to App name specified is already taken, please choose other name..
        /// </summary>
        internal static string ErrorAppNameTaken {
            get {
                return ResourceManager.GetString("ErrorAppNameTaken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your application has to support at least one platform..
        /// </summary>
        internal static string ErrorAtleastOnePlatformMustBeSelected {
            get {
                return ResourceManager.GetString("ErrorAtleastOnePlatformMustBeSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address specified is already taken, please use another email address..
        /// </summary>
        internal static string ErrorEmailTaken {
            get {
                return ResourceManager.GetString("ErrorEmailTaken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End Date can&apos;t be in the future.
        /// </summary>
        internal static string ErrorEndDateCantBeFuture {
            get {
                return ResourceManager.GetString("ErrorEndDateCantBeFuture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It&apos;s seems that there is an issue with our system, we have logged this issue, please try again later..
        /// </summary>
        internal static string ErrorGeneral {
            get {
                return ResourceManager.GetString("ErrorGeneral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid email address has been specified, please make sure your email address is correct..
        /// </summary>
        internal static string ErrorInvalidEmailAddress {
            get {
                return ResourceManager.GetString("ErrorInvalidEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We couldn&apos;t send an email invite to the following user(s) {0}, please try again later..
        /// </summary>
        internal static string ErrorInviteEmailCantBeSent {
            get {
                return ResourceManager.GetString("ErrorInviteEmailCantBeSent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following user(s) &lt;strong&gt;{0}&lt;/strong&gt; already have signed up or been invited. Please choose someone else..
        /// </summary>
        internal static string ErrorInviteEmailTaken {
            get {
                return ResourceManager.GetString("ErrorInviteEmailTaken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong email and password combination..
        /// </summary>
        internal static string ErrorLoginInvalid {
            get {
                return ResourceManager.GetString("ErrorLoginInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid email or password specified..
        /// </summary>
        internal static string ErrorLoginInvalidCredentials {
            get {
                return ResourceManager.GetString("ErrorLoginInvalidCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address specified was not found..
        /// </summary>
        internal static string ErrorNoSuchEmailAddress {
            get {
                return ResourceManager.GetString("ErrorNoSuchEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your current password dosen&apos;t match your current password..
        /// </summary>
        internal static string ErrorPasswordOldDontMatch {
            get {
                return ResourceManager.GetString("ErrorPasswordOldDontMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This link is no longer valid, please request password reset again..
        /// </summary>
        internal static string ErrorPasswordResetInvalidToken {
            get {
                return ResourceManager.GetString("ErrorPasswordResetInvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password and Password confirm need to match..
        /// </summary>
        internal static string ErrorPasswordsDontMatch {
            get {
                return ResourceManager.GetString("ErrorPasswordsDontMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password needs to be atleast 6 characters long, and Passwords need to match,.
        /// </summary>
        internal static string ErrorPasswordValidation {
            get {
                return ResourceManager.GetString("ErrorPasswordValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We couldn&apos;t send email to your new user,  please try adding your new user later..
        /// </summary>
        internal static string ErrorSettingsEmailCantBeSent {
            get {
                return ResourceManager.GetString("ErrorSettingsEmailCantBeSent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Information specified dosen&apos;t seem correct..
        /// </summary>
        internal static string ErrorValidation {
            get {
                return ResourceManager.GetString("ErrorValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;You must enter values in the following field(s):&lt;/strong&gt;.
        /// </summary>
        internal static string ErrorValidationSummary {
            get {
                return ResourceManager.GetString("ErrorValidationSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can’t verify this user, as such user doesn’t exist..
        /// </summary>
        internal static string ErrorVerificationInvalid {
            get {
                return ResourceManager.GetString("ErrorVerificationInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No data for date range selected..
        /// </summary>
        internal static string NotificationNoDataForDateRange {
            get {
                return ResourceManager.GetString("NotificationNoDataForDateRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select....
        /// </summary>
        internal static string PleaseSelect {
            get {
                return ResourceManager.GetString("PleaseSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application {0} was removed. No further action is required..
        /// </summary>
        internal static string SuccessAppRemoved {
            get {
                return ResourceManager.GetString("SuccessAppRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application was renamed to &lt;strong&gt;{0}&lt;/strong&gt;, no further action is required..
        /// </summary>
        internal static string SuccessAppRenamed {
            get {
                return ResourceManager.GetString("SuccessAppRenamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password reset request was sent to &lt;strong&gt;{0}&lt;/strong&gt;. Please follow instructions in the email..
        /// </summary>
        internal static string SuccessForgotPasswordRequest {
            get {
                return ResourceManager.GetString("SuccessForgotPasswordRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We have just sent invitations to your colleague(s) &lt;strong&gt; {0} &lt;/strong&gt; you have &lt;strong&gt; {1} &lt;/strong&gt; invitations left..
        /// </summary>
        internal static string SuccessInvite {
            get {
                return ResourceManager.GetString("SuccessInvite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password was changed successfully. Please &lt;a href=&quot;https://www.appacts.com/?login=true&quot;&gt; login now&lt;/a&gt; using your new password..
        /// </summary>
        internal static string SuccessPasswordReset {
            get {
                return ResourceManager.GetString("SuccessPasswordReset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password was changed succesfully..
        /// </summary>
        internal static string SuccessProfilePasswordChanged {
            get {
                return ResourceManager.GetString("SuccessProfilePasswordChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your profile was updated successfully..
        /// </summary>
        internal static string SuccessProfileUpdated {
            get {
                return ResourceManager.GetString("SuccessProfileUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User was added successfully..
        /// </summary>
        internal static string SuccessSettingsUserAdded {
            get {
                return ResourceManager.GetString("SuccessSettingsUserAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User was removed succesfully..
        /// </summary>
        internal static string SuccessSettingsUserRemoved {
            get {
                return ResourceManager.GetString("SuccessSettingsUserRemoved", resourceCulture);
            }
        }
    }
}

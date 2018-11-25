﻿using System;
using System.Management.Automation;
using System.Security;

namespace MSGraph.Exchange
{
    namespace Mail
    {
        /// <summary>
        /// name fo well-known-folders in a outlook mailboxes
        /// 
        /// Outlook creates certain folders for users by default. 
        /// Instead of using the corresponding folder id value, for convenience, 
        /// you can use the well-known folder names from the table below when accessing these folders. 
        /// 
        /// For example, you can get the Drafts folder using its well-known name with the following query.
        /// </summary>
        public enum WellKnownFolder
        {
            /// <summary>
            /// The archive folder messages are sent to when using the One_Click Archive feature in Outlook clients that support it. 
            /// Note: this is not the same as the Archive Mailbox feature of Exchange online.
            /// </summary>
            archive,

            /// <summary>
            /// The clutter folder low-priority messages are moved to when using the Clutter feature.
            /// </summary>
            clutter,

            /// <summary>
            /// The folder that contains conflicting items in the mailbox.
            /// </summary>
            conflicts,

            /// <summary>
            /// The folder where Skype saves IM conversations (if Skype is configured to do so).
            /// </summary>
            conversationhistory,

            /// <summary>
            /// The folder items are moved to when they are deleted.
            /// </summary>
            deleteditems,

            /// <summary>
            /// The folder that contains unsent messages.
            /// </summary>
            drafts,

            /// <summary>
            /// The inbox folder.
            /// </summary>
            inbox,

            /// <summary>
            /// The junk email folder.
            /// </summary>
            junkemail,

            /// <summary>
            /// The folder that contains items that exist on the local client but could not be uploaded to the server.
            /// </summary>
            localfailures,

            /// <summary>
            /// The "Top of Information Store" folder. This folder is the parent folder for folders that are displayed in normal mail clients, such as the inbox.
            /// </summary>
            msgfolderroot,

            /// <summary>
            /// The outbox folder.
            /// </summary>
            outbox,

            /// <summary>
            /// The folder that contains soft-deleted items: 
            /// deleted either from the Deleted Items folder, or by pressing shift+delete in Outlook. 
            /// This folder is not visible in any Outlook email client, but end users can interact with 
            /// it through the Recover Deleted Items from Server feature in Outlook or Outlook on the web.
            /// </summary>
            recoverableitemsdeletions,

            /// <summary>
            /// The folder that contains messages that are scheduled to reappear in the inbox using the Schedule feature in Outlook for iOS.
            /// </summary>
            scheduled,

            /// <summary>
            /// The parent folder for all search folders defined in the user's mailbox.
            /// </summary>
            searchfolders,

            /// <summary>
            /// The sent items folder.
            /// </summary>
            sentitems,

            /// <summary>
            /// The folder that contains items that exist on the server but could not be synchronized to the local client.
            /// </summary>
            serverfailures,

            /// <summary>
            /// The folder that contains synchronization logs created by Outlook.
            /// </summary>
            syncissues,
        }
    }
}

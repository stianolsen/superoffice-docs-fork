---
title: POST Ticket/Merge
uid: v1TicketEntity_MergeTickets
generated: true
---

# POST Ticket/Merge

```http
POST /api/v1/Ticket/Merge
```

Merge one or more tickets into one primary ticket







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| secondaryTicketIds | array | **Required** Ids of secondary tickets |
| mergedTicketEntity.ticketId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.title | string |  The title of the ticket. |
| mergedTicketEntity.createdAt | date-time |  When the ticket was created. |
| mergedTicketEntity.lastChanged | date-time |  The last time the ticket was modified. |
| mergedTicketEntity.readByOwner | date-time |  The datetime for when the ticket last was read by the owner. |
| mergedTicketEntity.readByCustomer | date-time |  The datetime for when the ticket was read by the customer. |
| mergedTicketEntity.firstReadByOwner | date-time |  The datetime for when the ticket first was read by the current owner. |
| mergedTicketEntity.firstReadByUser | date-time |  The datetime for when the ticket first was read by a user. |
| mergedTicketEntity.activate | date-time |  When the ticket should be activated, if it is postponed. |
| mergedTicketEntity.closedAt | date-time |  When the ticket was closed. |
| mergedTicketEntity.repliedAt | date-time |  The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| mergedTicketEntity.alertTimeout | date-time |  The datetime for when the ticket should jump to the next alert_level. |
| mergedTicketEntity.deadline | date-time |  Deadline for ticket. |
| mergedTicketEntity.createdBy.associateId | int32 |  Primary key |
| mergedTicketEntity.createdBy.name | string |  Initials, also login name, possibly database user name |
| mergedTicketEntity.createdBy.personId | int32 |  Owning person record Use MDO List name "person" to get list items. |
| mergedTicketEntity.createdBy.rank | int32 |  Rank order |
| mergedTicketEntity.createdBy.tooltip | string |  Tooltip or other description |
| mergedTicketEntity.createdBy.type | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| mergedTicketEntity.createdBy.groupIdx | int32 |  Primary group membership, see UserGroupLink for secondary memberships |
| mergedTicketEntity.createdBy.fullName | string |  The associate's culture formatted fullname (firstname, middleName and lastname) |
| mergedTicketEntity.createdBy.formalName | string |  The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| mergedTicketEntity.createdBy.deleted | bool |  If true, the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.createdBy.ejUserId | int32 |  ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| mergedTicketEntity.createdBy.userName | string |  User name |
| mergedTicketEntity.createdBy.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.createdBy.tableRight.reason | string |   |
| mergedTicketEntity.createdBy.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.author | string |  A string representing the author of the ticket (same as author of first message). |
| mergedTicketEntity.ownedBy.associateId | int32 |  Primary key |
| mergedTicketEntity.ownedBy.name | string |  Initials, also login name, possibly database user name |
| mergedTicketEntity.ownedBy.personId | int32 |  Owning person record Use MDO List name "person" to get list items. |
| mergedTicketEntity.ownedBy.rank | int32 |  Rank order |
| mergedTicketEntity.ownedBy.tooltip | string |  Tooltip or other description |
| mergedTicketEntity.ownedBy.type | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| mergedTicketEntity.ownedBy.groupIdx | int32 |  Primary group membership, see UserGroupLink for secondary memberships |
| mergedTicketEntity.ownedBy.fullName | string |  The associate's culture formatted fullname (firstname, middleName and lastname) |
| mergedTicketEntity.ownedBy.formalName | string |  The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| mergedTicketEntity.ownedBy.deleted | bool |  If true, the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.ownedBy.ejUserId | int32 |  ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| mergedTicketEntity.ownedBy.userName | string |  User name |
| mergedTicketEntity.ownedBy.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.ownedBy.tableRight.reason | string |   |
| mergedTicketEntity.ownedBy.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.ticketCategoryId | int32 |  The id of the ticket category. (primary key) |
| mergedTicketEntity.category.parentId | int32 |  The parent category for this category. -1 if this is a toplevel category. |
| mergedTicketEntity.category.name | string |  The (short) name of this category. E.g. &amp;apos;support&amp;apos;. |
| mergedTicketEntity.category.fullname | string |  The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;. |
| mergedTicketEntity.category.categoryMaster | int32 |  The user associated with this category. |
| mergedTicketEntity.category.flags | Enum: Unknown, Internal, OnlyLoggedInUsers, DefaultToCategoryMaster, ListInMain, RedelegateNewMsg, DelegateToOurContact, PropagateReplyTemplate, MembersOnly, NotifyMembers, AcceptWhenReplying |  A bitmask representing flags for this category. |
| mergedTicketEntity.category.delegateMethod | Enum: Unknown, Even, Weighted, Unfair, Not |  An integer indicating the delegation method for this category. |
| mergedTicketEntity.category.externalName | string |  The external name for this category, used for the customer frontend. |
| mergedTicketEntity.category.closingStatus | Enum: UserDefined, Active, Closed, Postponed |  Determines the default status used in the GUI when creating a ticket |
| mergedTicketEntity.category.msgClosingStatus | Enum: UserDefined, Active, Closed, Postponed |  Determines the default status used in the GUI when adding a request to a ticket |
| mergedTicketEntity.category.assignmentLag | int32 |  Number of minutes we shall override the assignment if a customer sends consecutive messages to this category |
| mergedTicketEntity.category.replyTemplate | int32 |  Reply template to merge with messages posted in this category |
| mergedTicketEntity.category.notificationEmail | string |  Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |
| mergedTicketEntity.category.defaultTicketStatus.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.category.defaultTicketStatus.name | string |  Name of user defined ticket status |
| mergedTicketEntity.category.defaultTicketStatus.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.category.defaultTicketStatus.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.category.defaultTicketStatus.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.category.defaultTicketStatus.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.category.defaultTicketStatus.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.category.defaultTicketStatus.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.category.defaultTicketStatus.tableRight.reason | string |   |
| mergedTicketEntity.category.defaultTicketStatus.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.defaultMessageStatus.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.category.defaultMessageStatus.name | string |  Name of user defined ticket status |
| mergedTicketEntity.category.defaultMessageStatus.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.category.defaultMessageStatus.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.category.defaultMessageStatus.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.category.defaultMessageStatus.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.category.defaultMessageStatus.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.category.defaultMessageStatus.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.category.defaultMessageStatus.tableRight.reason | string |   |
| mergedTicketEntity.category.defaultMessageStatus.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.effectiveReplyTemplateId | int32 |  Id of reply template to merge into messages, whose ticket belongs to this category. Also takes into account 'Apply to subcategories' on parent categories. This is a calculated, readonly field. |
| mergedTicketEntity.category.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead.Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.category.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.Custom fields combines user defined fields and extra fields into one bucket. The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of thiscombined collection. |
| mergedTicketEntity.category.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.category.tableRight.reason | string |   |
| mergedTicketEntity.category.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.slevel | Enum: Unknown, Internal, External |  The securitylevel of the ticket. |
| mergedTicketEntity.priority.ticketPriorityId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.priority.name | string |  The name of the priority. |
| mergedTicketEntity.priority.status | Enum: Unknown, Normal, Deleted |  The status (normal/deleted) of the priority. |
| mergedTicketEntity.priority.flags | Enum: Unknown, External, Default, AlertSchedule |  A bitmask of flags. |
| mergedTicketEntity.priority.sortOrder | int32 |  Indicates the sort order for this priority. 1 is first, 100 is last |
| mergedTicketEntity.priority.ticketRead | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request is read |
| mergedTicketEntity.priority.changedOwner | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request changes owner (manually) |
| mergedTicketEntity.priority.ticketNewinfo | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request gets new info |
| mergedTicketEntity.priority.ticketClosed | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request is closed |
| mergedTicketEntity.priority.ticketChangedPriority | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request is changed into this priority |
| mergedTicketEntity.priority.ticketNew | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when a new request is registered |
| mergedTicketEntity.priority.deadline | int32 |  Deadline to add if escalated (minutes) |
| mergedTicketEntity.priority.monStart | date-time |  The work hour start for Mondays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.monStop | date-time |  The work hour start for Mondays. Note that only the time part of the DateTime is used |

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| mergedTicketEntity.priority.tueStop | date-time |  The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.wedStart | date-time |  The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.wedStop | date-time |  The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.thuStart | date-time |  The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.thuStop | date-time |  The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.friStart | date-time |  The work hour start for Fridays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.friStop | date-time |  The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.satStart | date-time |  The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.satStop | date-time |  The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.sunStart | date-time |  The work hour start for Sundays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.sunStop | date-time |  The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.nonDates | array |  Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| mergedTicketEntity.priority.escalationLevels | array |  Escalation levels bound to the parent priority |
| mergedTicketEntity.priority.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.priority.tableRight.reason | string |   |
| mergedTicketEntity.priority.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.baseStatus | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The status of the ticket. I.e. active/closed/postponed/deleted Use MDO List name "ticketstatus" to get list items. |
| mergedTicketEntity.status.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.status.name | string |  Name of user defined ticket status |
| mergedTicketEntity.status.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.status.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.status.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.status.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.status.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.status.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.status.tableRight.reason | string |   |
| mergedTicketEntity.status.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.origin | Enum: Unknown, Email, SMS, Fax, Phone, Facebook, Twitter, Internal, CustomerCentre, EMarketing, AutoGenerated, Chat, Form |  What is the origin of this ticket |
| mergedTicketEntity.person.position | string |  The position. This is a predefined SuperOffice value, different from Title |
| mergedTicketEntity.person.personId | int32 |  Primary key |
| mergedTicketEntity.person.mrmrs | string |  e.g. Mrs   sex_title |
| mergedTicketEntity.person.firstname | string |  First name |
| mergedTicketEntity.person.lastname | string |  Last name |
| mergedTicketEntity.person.middleName | string |  Middle name or 'van' etc. |
| mergedTicketEntity.person.title | string |  Title |
| mergedTicketEntity.person.description | string |  Info text/description on person. |
| mergedTicketEntity.person.email | string |  First email on contact person. |
| mergedTicketEntity.person.fullName | string |  Get the persons full name (internal name used in clients for employees). |
| mergedTicketEntity.person.directPhone | string |  Returns the direct phone that belong to the contact person. |
| mergedTicketEntity.person.formalName | string |  Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| mergedTicketEntity.person.countryId | int32 |  Country |
| mergedTicketEntity.person.contactId | int32 |  Owning contact ID |
| mergedTicketEntity.person.contactName | string |  The persons company name |
| mergedTicketEntity.person.retired | int32 |  1 = the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.person.rank | int32 |  Display sort sequence for default sort order |
| mergedTicketEntity.person.activeInterests | int32 |  Number of records in pintr table; select count(*) from pintr pi where pi.person_id = this.person_id == activeInterests is always true |
| mergedTicketEntity.person.contactDepartment | string |  The persons contact department |
| mergedTicketEntity.person.contactCountryId | int32 |  The persons contact country id |
| mergedTicketEntity.person.contactOrgNr | string |  The persons contact organization number |
| mergedTicketEntity.person.faxPhone | string |  Returns the fax phone that belong to the contact person. |
| mergedTicketEntity.person.mobilePhone | string |  Returns the mobile phone that belong to the contact person. |
| mergedTicketEntity.person.contactPhone | string |  Returns the direct phone that belong to the persons contact. |
| mergedTicketEntity.person.associateName | string |  Name of the person's owner |
| mergedTicketEntity.person.associateId | int32 |  Id of the item's owner (Associate id) |
| mergedTicketEntity.person.usePersonAddress | bool |  If 1, use person's address for mailing instead of company address |
| mergedTicketEntity.person.contactFax | string |  Actual phone number as eneterd by the user |
| mergedTicketEntity.person.kanafname | string |  Kana first name, used in Japanese versions only |
| mergedTicketEntity.person.kanalname | string |  Kana last name, used in Japanese versions only |
| mergedTicketEntity.person.post1 | string |  Postal address, used in Japanese versions only |
| mergedTicketEntity.person.post2 | string |  Postal address, used in Japanese versions only |
| mergedTicketEntity.person.post3 | string |  Postal address, used in Japanese versions only |
| mergedTicketEntity.person.emailName | string |  E-mail description |
| mergedTicketEntity.person.contactFullName | string |  Company full name + department |
| mergedTicketEntity.person.activeErpLinks | int32 |  How many active ERP links are there for this person? |
| mergedTicketEntity.person.ticketPriorityId | int32 |  Ticket priority ID |
| mergedTicketEntity.person.supportLanguageId | int32 |  Support priority ID |
| mergedTicketEntity.person.supportAssociateId | int32 |  Our support contact for this person |
| mergedTicketEntity.person.categoryName | string |  The category list item name |
| mergedTicketEntity.person.personNumber | string |  Alphanumeric user field |
| mergedTicketEntity.person.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.person.tableRight.reason | string |   |
| mergedTicketEntity.person.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.secondaryPersons | array |  The secondary persons this ticket is connected to Use MDO List name "person_new" to get list items. |
| mergedTicketEntity.alertLevel | int32 |  The alert level for the ticket. Matches the level value of the ticket_alert table. |
| mergedTicketEntity.connectId | int32 |  If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| mergedTicketEntity.readStatus | Enum: Unknown, Green, Yellow, Red |  Whether the owner has read the ticket or not (red, yellow, green). |
| mergedTicketEntity.timeToReply | int32 |  The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| mergedTicketEntity.realTimeToReply | int32 |  Same as time_to_reply, but not calculated based on priority. |
| mergedTicketEntity.timeToClose | int32 |  The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| mergedTicketEntity.realTimeToClose | int32 |  Same as time_to_close, but not calculated based on priority. |
| mergedTicketEntity.timeSpentInternally | int32 |  The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| mergedTicketEntity.timeSpentExternally | int32 |  The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| mergedTicketEntity.timeSpentQueue | int32 |  The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| mergedTicketEntity.realTimeSpentInternally | int32 |  The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| mergedTicketEntity.realTimeSpentExternally | int32 |  The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| mergedTicketEntity.realTimeSpentQueue | int32 |  The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| mergedTicketEntity.timeSpent | int32 |  The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
| mergedTicketEntity.hasAttachment | bool |  Boolean indicating if this ticket has one or more attachments. |
| mergedTicketEntity.numReplies | int32 |  The number of replies (messages) to the customer for this request. |
| mergedTicketEntity.numMessages | int32 |  The total number of messages for this request. |
| mergedTicketEntity.fromAddress | string |  The from-address used when this ticket got created, e.g. by email |
| mergedTicketEntity.messages | array |  TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| mergedTicketEntity.tags | array |  An array containing the tags assigned to this request |
| mergedTicketEntity.language | string |  The language of the first external message |
| mergedTicketEntity.sentiment | int32 |  The sentiment index of the last external message |
| mergedTicketEntity.sentimentConfidence | int32 |  The sentiment confidence of the last external message |
| mergedTicketEntity.suggestedCategoryId | int32 |  Suggestion for categorization, based on the text of the message (AI) |
| mergedTicketEntity.suggestedCategoryName | string |  Suggested category from AI |
| mergedTicketEntity.origHumanCategoryId | int32 |  Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| mergedTicketEntity.sale.contactName | string |  Contact name |
| mergedTicketEntity.sale.saleDate | date-time |  (expected / lost / won) sales date |
| mergedTicketEntity.sale.saleId | int32 |  Primary key |
| mergedTicketEntity.sale.probability | int32 |  Actual probability, may differ from the one in the list |
| mergedTicketEntity.sale.title | string |  Sale heading (short description?) |
| mergedTicketEntity.sale.amount | double |  Total sale amount |
| mergedTicketEntity.sale.currency | string |  Currency the sale was made in. |
| mergedTicketEntity.sale.projectName | string |  Project name |
| mergedTicketEntity.sale.associateFullName | string |  The sale's owner |
| mergedTicketEntity.sale.description | string |  The sales description |
| mergedTicketEntity.sale.status | Enum: Unknown, Open, Sold, Lost, Stalled, SaintAll |  The sale's status, indicating wether the sale is open, sold or lost. |
| mergedTicketEntity.sale.weightedAmount | double |  The weighted amount ( amount *  probability / 100) |
| mergedTicketEntity.sale.projectId | int32 |  Optional project reference |
| mergedTicketEntity.sale.earningPercent | double |  Earning as percent of total |
| mergedTicketEntity.sale.earning | double |  Earning on sale |
| mergedTicketEntity.sale.contactId | int32 |  Optional contact reference |
| mergedTicketEntity.sale.associateId | int32 |  The sale's owner id |
| mergedTicketEntity.sale.personId | int32 |  The sale's contact persons id |
| mergedTicketEntity.sale.saleTypeId | int32 |  The sale's type id |
| mergedTicketEntity.sale.saleTypeName | string |  The sale's type name |
| mergedTicketEntity.sale.personFullName | string |  The name of the person this sale belongs to. |
| mergedTicketEntity.sale.completed | Enum: Unknown, NotStarted, Started, Completed |  The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| mergedTicketEntity.sale.activeErpLinks | int32 |  The number of active erp links |
| mergedTicketEntity.sale.nextDueDate | date-time |  Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| mergedTicketEntity.sale.number | string |  Alphanumeric user field |
| mergedTicketEntity.sale.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.sale.tableRight.reason | string |   |
| mergedTicketEntity.sale.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.project.projectId | int32 |  Primary key |
| mergedTicketEntity.project.name | string |  Project name |
| mergedTicketEntity.project.description | string |  The projects description |
| mergedTicketEntity.project.uRL | string |  URL address |
| mergedTicketEntity.project.type | string |  The project type. |
| mergedTicketEntity.project.associateId | int32 |  The project owner id (associate id) |
| mergedTicketEntity.project.associateFullName | string |  The project owner |
| mergedTicketEntity.project.typeId | int32 |   |
| mergedTicketEntity.project.updated | date-time |  Last updated date  in UTC. |
| mergedTicketEntity.project.statusId | int32 |  The projects status id |
| mergedTicketEntity.project.status | string |  The projects status |
| mergedTicketEntity.project.textId | int32 |  The id of the description |
| mergedTicketEntity.project.publishTo | date-time |  Publication valid to (inclusive) |
| mergedTicketEntity.project.publishFrom | date-time |  Publication valid from (inclusive) |
| mergedTicketEntity.project.isPublished | bool |   |
| mergedTicketEntity.project.uRLName | string |  Visible field |
| mergedTicketEntity.project.projectNumber | string |  Automatically generated number |
| mergedTicketEntity.project.activeErpLinks | int32 |  The number of active erp links |
| mergedTicketEntity.project.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.project.tableRight.reason | string |   |
| mergedTicketEntity.project.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.formSubmission.formSubmissionId | int32 |  Primary key |
| mergedTicketEntity.formSubmission.emailAddress | string |  The email address of the person who submitted |
| mergedTicketEntity.formSubmission.status | Enum: Unknown, InProgress, EmailVerification, Submitted, Processed, Failed |  What is the status of this submission |
| mergedTicketEntity.ticketType.ticketTypeId | int32 |  Primary key |
| mergedTicketEntity.ticketType.name | string |  The list item |
| mergedTicketEntity.ticketType.icon | string |  Name of the icon |
| mergedTicketEntity.ticketType.defaultTicketStatus | int32 |  Default ticket status for new tickets |
| mergedTicketEntity.ticketType.defaultTicketPriority | int32 |  Default ticket priority for new tickets |
| mergedTicketEntity.ticketType.isDefault | bool |  Is this Ticket Type marked as default |
| mergedTicketEntity.ticketType.showInNew | bool |  Enables this request type to be accessible in +New in top bar |
| mergedTicketEntity.ticketType.excludeSignature | bool |  Do not insert user signature automatically |
| mergedTicketEntity.ticketType.excludeEmailRecipients | bool |  Create request without initially having to send outbound e-mail |
| mergedTicketEntity.ticketType.externalAsDefault | bool |  Ability to set external access level for this request type |
| mergedTicketEntity.ticketType.visibleForGroups | array |  Array of references to the visible for groups |
| mergedTicketEntity.ticketType.replyForwardNoSignature | bool |  Do not insert user signature when replying or forwarding the message |
| mergedTicketEntity.ticketType.replyExternalAsDefault | bool |  Set external access level when replying the message |
| mergedTicketEntity.ticketType.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.ticketType.tableRight.reason | string |   |
| mergedTicketEntity.ticketType.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.activeStatusMonitorId | int32 |  Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| mergedTicketEntity.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead.Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.Custom fields combines user defined fields and extra fields into one bucket. The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of thiscombined collection. |
| mergedTicketEntity.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.tableRight.reason | string |   |
| mergedTicketEntity.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |

```http
POST /api/v1/Ticket/Merge?secondaryTicketIds=655,276
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketId=518
POST /api/v1/Ticket/Merge?mergedTicketEntity.title=impedit
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdAt=05/11/2017 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.lastChanged=08/07/2010 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByOwner=12/02/2015 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByCustomer=09/16/2020 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByOwner=06/22/2006 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByUser=08/22/2001 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.activate=01/27/2020 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.closedAt=12/11/2015 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.repliedAt=10/23/2001 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertTimeout=07/05/2012 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.deadline=12/08/2017 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.associateId=883
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.name=consequatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.personId=959
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.rank=298
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tooltip=ipsam
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.groupIdx=313
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fullName=Bailey, Franecki and Turcotte
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.formalName=Spencer-Nienow
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.deleted=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.ejUserId=1000
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.userName=DuBuque-Schmidt
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.reason=totam
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.author=ipsa
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.associateId=691
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.name=voluptatem
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.personId=373
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.rank=734
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tooltip=neque
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.groupIdx=238
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fullName=Miller Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.formalName=Weber Group
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.deleted=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.ejUserId=855
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.userName=Ledner-Ankunding
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.reason=laborum
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.ticketCategoryId=625
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.parentId=375
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.name=nesciunt
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fullname=ea
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.categoryMaster=422
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.flags=AcceptWhenReplying
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.delegateMethod=Even
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.externalName=Kerluke, Heidenreich and Schimmel
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.closingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.msgClosingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.assignmentLag=904
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.replyTemplate=727
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.notificationEmail=aidan@waters.name
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.ticketStatusId=106
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.name=enim
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.reason=quam
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.ticketStatusId=39
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.name=est
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.usedInQueue=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.reason=eius
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.effectiveReplyTemplateId=988
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.reason=maiores
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.slevel=External
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketPriorityId=911
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.name=molestiae
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.status=Deleted
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.flags=AlertSchedule
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sortOrder=476
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketRead=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.changedOwner=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNewinfo=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketClosed=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketChangedPriority=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNew=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.deadline=297
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStart=10/22/2019 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStop=07/23/2018 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStart=02/06/2010 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStop=07/14/2017 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStart=01/06/2007 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStop=03/06/2012 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStart=07/23/2015 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStop=06/21/2008 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStart=12/27/2004 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStop=05/04/2007 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStart=05/06/2002 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStop=08/31/2007 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStart=05/16/2017 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStop=01/02/2017 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.nonDates=hic,omnis
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.escalationLevels=laudantium,eos
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.reason=in
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.baseStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.ticketStatusId=703
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.name=illo
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.reason=tempore
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.origin=AutoGenerated
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.position=facilis
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.personId=241
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mrmrs=corrupti
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.firstname=cum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.lastname=autem
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.middleName=Wolff-Spencer
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.title=culpa
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.description=harum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.email=dolores
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fullName=Koelpin, Franecki and Weimann
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.directPhone=1-207-593-4523
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.formalName=Hauck, Stark and Bednar
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.countryId=92
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactId=517
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactName=Mertz LLC
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.retired=856
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.rank=130
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeInterests=296
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactDepartment=
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactCountryId=328
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactOrgNr=233602
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.faxPhone=1-214-757-1818 x7850
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mobilePhone=(930)466-2628
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactPhone=123.505.2571 x718
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateName=Leffler Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateId=752
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.usePersonAddress=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFax=aut
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanafname=molestiae
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanalname=repudiandae
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post1=cum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post2=est
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post3=ullam
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.emailName=Nikolaus, Schaefer and Upton
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFullName=Keira Lockman
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeErpLinks=143
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.ticketPriorityId=433
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportLanguageId=211
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportAssociateId=183
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.categoryName=Erdman-Hackett
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.personNumber=1175716
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.reason=dicta
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.secondaryPersons=quos,praesentium
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertLevel=423
POST /api/v1/Ticket/Merge?mergedTicketEntity.connectId=471
POST /api/v1/Ticket/Merge?mergedTicketEntity.readStatus=Green
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToReply=853
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToReply=555
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToClose=382
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToClose=144
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentInternally=287
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentExternally=329
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentQueue=617
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentInternally=425
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentExternally=968
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentQueue=861
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpent=810
POST /api/v1/Ticket/Merge?mergedTicketEntity.hasAttachment=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.numReplies=10
POST /api/v1/Ticket/Merge?mergedTicketEntity.numMessages=801
POST /api/v1/Ticket/Merge?mergedTicketEntity.fromAddress=molestias
POST /api/v1/Ticket/Merge?mergedTicketEntity.messages=illum,atque
POST /api/v1/Ticket/Merge?mergedTicketEntity.tags=ratione,et
POST /api/v1/Ticket/Merge?mergedTicketEntity.language=recusandae
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentiment=597
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentimentConfidence=85
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryId=129
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryName=VIP Customer
POST /api/v1/Ticket/Merge?mergedTicketEntity.origHumanCategoryId=737
POST /api/v1/Ticket/Merge?mergedTicketEntity.iconHint=suscipit
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactName=Swaniawski-Eichmann
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleDate=02/16/2004 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleId=734
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.probability=466
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.title=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.amount=335.338
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.currency=adipisci
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectName=Haley-Zboncak
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateFullName=Theron Hayes
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.description=saepe
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.status=Lost
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.weightedAmount=26635.866
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectId=298
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earningPercent=2052.77
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earning=11041.082
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactId=43
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateId=74
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personId=234
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeId=136
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeName=Block, Skiles and Hodkiewicz
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personFullName=Estella Cummings
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.completed=Completed
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.activeErpLinks=731
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.nextDueDate=05/02/2009 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.number=qui
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.reason=vel
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectId=452
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.name=consequatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.description=id
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRL=amet
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.type=sapiente
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateId=75
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateFullName=Rick Larissa Armstrong Sr.
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.typeId=980
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.updated=01/08/2010 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.statusId=866
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.status=sint
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.textId=232
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishTo=01/25/1999 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishFrom=09/20/2005 16:32:50
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.isPublished=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRLName=Watsica, Hane and Hettinger
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectNumber=1394590
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.activeErpLinks=245
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.reason=quod
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.formSubmissionId=337
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.emailAddress=reprehenderit
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.status=EmailVerification
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.ticketTypeId=904
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.name=quaerat
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.icon=praesentium
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketStatus=424
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketPriority=108
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.showInNew=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.excludeSignature=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.excludeEmailRecipients=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.externalAsDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.visibleForGroups=718,543
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.replyForwardNoSignature=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.replyExternalAsDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.reason=error
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.activeStatusMonitorId=368
POST /api/v1/Ticket/Merge?mergedTicketEntity.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.reason=itaque
POST /api/v1/Ticket/Merge?mergedTicketEntity.fieldProperties=An object of some kind
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | date-time | The datetime for when the ticket first was read by the current owner. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy | Associate | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  Use MDO List name "associate" to get list items. |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  Use MDO List name "ejcategory" to get list items. |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  Use MDO List name "ticketpriority" to get list items. |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  Use MDO List name "ticketstatus" to get list items. |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  Use MDO List name "ticketstatus" to get list items. |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  Use MDO List name "person_new" to get list items. |
| SecondaryPersons | array | The secondary persons this ticket is connected to  Use MDO List name "person_new" to get list items. |
| AlertLevel | int32 | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | int32 | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | string | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | int32 | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | int32 | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | int32 | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | int32 | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | int32 | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | int32 | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | int32 | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | int32 | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| TimeSpent | int32 | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
| HasAttachment | bool | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | int32 | The number of replies (messages) to the customer for this request. |
| NumMessages | int32 | The total number of messages for this request. |
| FromAddress | string | The from-address used when this ticket got created, e.g. by email |
| Messages | array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | array | An array containing the tags assigned to this request |
| Language | string | The language of the first external message |
| Sentiment | int32 | The sentiment index of the last external message |
| SentimentConfidence | int32 | The sentiment confidence of the last external message |
| SuggestedCategoryId | int32 | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | string | Suggested category from AI |
| OrigHumanCategoryId | int32 | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | string | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket is connected to  Use MDO List name "sale" to get list items. |
| Project | Project | The project that this ticket is connected to  Use MDO List name "project" to get list items. |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  Use MDO List name "TicketType" to get list items. |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Ticket/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 73,
  "Title": "aut",
  "CreatedAt": "2007-06-13T16:32:48.2119318+02:00",
  "LastChanged": "2024-06-24T16:32:48.2119318+02:00",
  "ReadByOwner": "2005-10-25T16:32:48.2119318+02:00",
  "ReadByCustomer": "2013-01-24T16:32:48.2119318+01:00",
  "FirstReadByOwner": "2009-10-21T16:32:48.2119318+02:00",
  "FirstReadByUser": "2009-01-05T16:32:48.2119318+01:00",
  "Activate": "2017-03-24T16:32:48.2119318+01:00",
  "ClosedAt": "2018-05-11T16:32:48.2119318+02:00",
  "RepliedAt": "2007-04-11T16:32:48.2119318+02:00",
  "AlertTimeout": "2021-05-03T16:32:48.2119318+02:00",
  "Deadline": "2011-07-03T16:32:48.2119318+02:00",
  "CreatedBy": null,
  "Author": "non",
  "OwnedBy": null,
  "Category": null,
  "Slevel": "External",
  "Priority": null,
  "BaseStatus": "Active",
  "Status": null,
  "Origin": "AutoGenerated",
  "Person": null,
  "SecondaryPersons": [
    {
      "Position": "alias",
      "PersonId": 869,
      "Mrmrs": "soluta",
      "Firstname": "Dejon",
      "Lastname": "Thompson",
      "MiddleName": "Herzog Inc and Sons",
      "Title": "explicabo",
      "Description": "Optional hybrid moratorium",
      "Email": "jennie@murphy.uk",
      "FullName": "Rick Harris",
      "DirectPhone": "153.148.0986 x9280",
      "FormalName": "Hills, Abshire and Hills",
      "CountryId": 995,
      "ContactId": 452,
      "ContactName": "Kuhn-Johnston",
      "Retired": 370,
      "Rank": 571,
      "ActiveInterests": 461,
      "ContactDepartment": "",
      "ContactCountryId": 459,
      "ContactOrgNr": "1437354",
      "FaxPhone": "996-085-1507 x1491",
      "MobilePhone": "1-252-361-2981 x3591",
      "ContactPhone": "(596)928-6071 x5050",
      "AssociateName": "Haag, Wuckert and Lynch",
      "AssociateId": 147,
      "UsePersonAddress": true,
      "ContactFax": "distinctio",
      "Kanafname": "perspiciatis",
      "Kanalname": "non",
      "Post1": "facilis",
      "Post2": "voluptas",
      "Post3": "id",
      "EmailName": "deborah@hahn.info",
      "ContactFullName": "Burley Rath",
      "ActiveErpLinks": 289,
      "TicketPriorityId": 348,
      "SupportLanguageId": 351,
      "SupportAssociateId": 103,
      "CategoryName": "VIP Customer",
      "PersonNumber": "707544",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 642
        }
      }
    }
  ],
  "AlertLevel": 260,
  "ConnectId": 95,
  "ReadStatus": "Green",
  "TimeToReply": 289,
  "RealTimeToReply": 100,
  "TimeToClose": 113,
  "RealTimeToClose": 264,
  "TimeSpentInternally": 180,
  "TimeSpentExternally": 133,
  "TimeSpentQueue": 663,
  "RealTimeSpentInternally": 434,
  "RealTimeSpentExternally": 798,
  "RealTimeSpentQueue": 917,
  "TimeSpent": 981,
  "HasAttachment": true,
  "NumReplies": 387,
  "NumMessages": 520,
  "FromAddress": "vel",
  "Messages": [
    {
      "TicketMessageId": 292,
      "CreatedAt": "2013-06-29T16:32:48.2119318+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "velit",
      "PersonId": 379,
      "PersonFullName": "Prof. Oral Savannah Heller",
      "ContactId": 350,
      "ContactName": "Hamill, Langworth and Klein",
      "ContactDepartment": "",
      "NumAttachments": 723,
      "EmailHeader": "alessandro_thompson@tremblay.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "qui",
      "Sentiment": 174,
      "SentimentConfidence": 139,
      "CreatedBy": 458,
      "ChangedAt": "2024-01-20T16:32:48.2119318+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 936,
      "Name": "Skiles-Schaden",
      "ToolTip": "Voluptatum porro voluptatem reiciendis necessitatibus autem eligendi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    },
    {
      "Id": 936,
      "Name": "Skiles-Schaden",
      "ToolTip": "Voluptatum porro voluptatem reiciendis necessitatibus autem eligendi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    }
  ],
  "Language": "eum",
  "Sentiment": 13,
  "SentimentConfidence": 778,
  "SuggestedCategoryId": 19,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 965,
  "IconHint": "quidem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 757,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "ab"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 534
    }
  }
}
```
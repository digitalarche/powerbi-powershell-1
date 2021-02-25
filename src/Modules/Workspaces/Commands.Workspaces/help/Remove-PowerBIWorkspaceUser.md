---
external help file: Microsoft.PowerBI.Commands.Workspaces.dll-Help.xml
Module Name: MicrosoftPowerBIMgmt.Workspaces
online version: https://docs.microsoft.com/en-us/powershell/module/microsoftpowerbimgmt.workspaces/remove-powerbiworkspaceuser?view=powerbi-ps
schema: 2.0.0
---

# Remove-PowerBIWorkspaceUser

## SYNOPSIS
Removes permissions to a Power BI workspace for the specified user.

## SYNTAX

### Id (Default)
```
Remove-PowerBIWorkspaceUser [-Scope <PowerBIUserScope>] -Id <Guid> -UserPrincipalName <String>
 [<CommonParameters>]
```

### Workspace
```
Remove-PowerBIWorkspaceUser [-Scope <PowerBIUserScope>] -UserPrincipalName <String> -Workspace <Workspace>
 [<CommonParameters>]
```

## DESCRIPTION
Removes permissions for a specified user to a Power BI workspace using the provided inputs and scope specified.
Before you run this command, make sure you log in using Connect-PowerBIServiceAccount. 

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-PowerBIWorkspaceUser -Scope Organization -Id 23FCBDBD-A979-45D8-B1C8-6D21E0F4BE50 -UserEmailAddress john@contoso.com
```

Removes permissions for user john@contoso.com on workspace with ID 23FCBDBD-A979-45D8-B1C8-6D21E0F4BE50 within the caller's organization.

### Example 2
```powershell
PS C:\> Remove-PowerBIWorkspaceUser -Scope Individual -Id 23FCBDBD-A979-45D8-B1C8-6D21E0F4BE50 -UserEmailAddress john@contoso.com
```

Removes permissions for john@contoso.com on workspace with ID 23FCBDBD-A979-45D8-B1C8-6D21E0F4BE50, which is a workpace the caller owns.

## PARAMETERS

### -Id
ID of the workspace the user should be removed from.

```yaml
Type: Guid
Parameter Sets: Id
Aliases: GroupId, WorkspaceId

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Scope
Indicates scope of the call. Individual operates against only workspaces assigned to the caller; Organization operates against all workspaces within a tenant (must be an administrator to initiate). Individual is the default.

```yaml
Type: PowerBIUserScope
Parameter Sets: (All)
Aliases:
Accepted values: Individual, Organization

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
User Principal Name (or UPN, commonly an email address) for the user whose permissions need to be removed.

```yaml
Type: String
Parameter Sets: (All)
Aliases: UserEmailAddress

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Workspace
The workspace entity to remove the user from.

```yaml
Type: Workspace
Parameter Sets: Workspace
Aliases: Group

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (https://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.Object

## NOTES

## RELATED LINKS

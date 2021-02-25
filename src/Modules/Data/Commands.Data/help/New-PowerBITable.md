---
external help file: Microsoft.PowerBI.Commands.Data.dll-Help.xml
Module Name: MicrosoftPowerBIMgmt.Data
online version:
schema: 2.0.0
---

# New-PowerBITable

## SYNOPSIS
Creates a new Power BI table object.

## SYNTAX

```
New-PowerBITable -Name <String> [-Columns <Column[]>] [<CommonParameters>]
```

## DESCRIPTION
Initiates the creation of a new Power BI table object. A table is a container for columns and rows, and contained within datasets.

## EXAMPLES

### Example 1
```powershell
PS C:\>$col1 = New-PowerBIColumn -Name ID -DataType Int64
PS C:\>$col2 = New-PowerBIColumn -Name Data -DataType String
PS C:\>$table1 = New-PowerBITable -Name SampleTable1 -Columns $col1,$col2
PS C:\>
PS C:\>$col3 = New-PowerBIColumn -Name ID -DataType Int64
PS C:\>$col4 = New-PowerBIColumn -Name Date -DataType DateTime
PS C:\>$col5 = New-PowerBIColumn -Name Detail -DataType String
PS C:\>$col6 = New-PowerBIColumn -Name Result -DataType Double
PS C:\>$table2 = New-PowerBITable -Name SampleTable2 -Columns $col3,$col4,$col5,$col6
PS C:\>
PS C:\>$dataset = New-PowerBIDataSet -Name SampleDataSet -Tables $table1,$table2
PS C:\>
PS C:\>Add-PowerBIDataSet -DataSet $dataset
```

This example instantiate a table with two columns and another table with four columns, and instantiates a dataset.
Then, it creates the dataset in Power BI.

## PARAMETERS

### -Columns
An array of column objects.

```yaml
Type: Column[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the table.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (https://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.PowerBI.Common.Api.Datasets.Table

## NOTES

## RELATED LINKS

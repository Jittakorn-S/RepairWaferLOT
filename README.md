# Repair Wafer LOT

A simple utility to repair wafer lot data files by correcting wafer sequence information and updating lot names. This tool is designed for semiconductor manufacturing environments where wafer data files (`.DAT`) can become corrupted or require manual correction.

## Description

The **Repair Wafer LOT** application provides a straightforward graphical user interface to fix issues in `LOT.DAT` files. It operates in two modes, **Wafer Mapping** and **After AOI**, to handle different stages of the manufacturing process. The tool reads a specified lot number, identifies the associated wafer data files, and then programmatically writes the correct wafer sequence and lot name into the binary `LOT.DAT` file.

This is particularly useful when the number and sequence of wafers are incorrectly represented in the lot file, which can happen for various reasons during automated processing. The application ensures data integrity for downstream operations.

## Features

  * **Corrects Wafer Information**: Automatically repairs the wafer number sequence within the `LOT.DAT` file.
  * **Updates Lot Name**: Converts the ASCII lot name provided by the user into hexadecimal format and writes it into the `LOT.DAT` file.
  * **Two Operational Modes**:
      * **WaferMapping**: For lots processed through the wafer mapping stage.
      * **AfterAOI**: For lots processed after Automated Optical Inspection (AOI).
  * **Simple User Interface**: An intuitive interface for ease of use, requiring only the lot number and the selection of a processing mode.
  * **Handles Full and Partial Lots**: Includes logic to correctly handle both full lots of 25 wafers and partial lots with fewer wafers.

## How to Use

1.  **Launch the application**.
2.  In the main window, **enter the target lot number** into the text field.
3.  **Select the appropriate mode** by clicking either the `WaferMapping` or `AfterAOI` radio button.
4.  Click the **Repair** button to start the process.
5.  The application will then locate the specified directory, read the `W-NO-*.DAT` files to determine the correct wafer sequence, and write the corrected data to the `LOT.DAT` file.
6.  A "Repair Success" message will appear upon completion.

## Configuration

Before using the application, you must configure the file paths in the `App.config` file. These paths tell the application where to find the lot folders.

Open `App.config` and modify the `value` for the following keys to point to your data directories:

```xml
<configuration>
	...
	<appSettings>
		<add key="WaferMappingPath"  value="C:\\Users\\Desktop\\WaferMapping\\"  />
		<add key="AfterAOIPath"  value="C:\\Users\\Desktop\\AfterAOI\\"  />
	</appSettings>
</configuration>
```

  * **`WaferMappingPath`**: The base directory where lot folders from the Wafer Mapping process are stored.
  * **`AfterAOIPath`**: The base directory where lot folders from the After AOI process are stored.

The application will append the lot number entered in the UI to these paths to find the correct folder.

## Prerequisites

  * .NET Framework 4.7.2 or later.

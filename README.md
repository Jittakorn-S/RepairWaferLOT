# EDS Page

This repository contains the source code for the EDS Top Page, a web portal for accessing various internal systems related to LSI production.

## Description

The EDS Top Page serves as a centralized index of links to different web-based tools and systems used in the EDS (Electrical Die Sorting) process of LSI (Large-Scale Integration) production. It provides a user-friendly interface with different zones for various departments or functions.

## Features

* **Centralized Portal:** Provides a single point of access to multiple internal web services.
* **Organized by Zones:** The page is divided into the following zones for easy navigation:
    * COMMON ZONE
    * PD ZONE
    * PM ZONE
    * TE ZONE
* **Responsive Design:** The page layout adjusts for different screen sizes.
* **Custom Error Pages:** Includes custom HTML pages for various HTTP error codes to provide a consistent user experience.

## Pages

### Main Page

* **`EDSTopPage.html`**: The main entry point of the web application. It displays the links to the various systems.

### Error Pages

* `401.html`: Unauthorized
* `403.html`: Forbidden
* `404.html`: Page Not Found
* `405.html`: Method Not Allowed
* `406.html`: Not Acceptable
* `412.html`: Precondition Failed
* `500.html`: Internal Server Error
* `501.html`: Not Implemented
* `502.html`: Bad Gateway

## Installation

To use this page, set `EDSTopPage.html` as the default or index page on your web server.

## Usage

Once the page is set up, users can navigate to the main page and click on the "Enter" button for the desired system. The links on the page are configured to redirect to the respective internal web services.

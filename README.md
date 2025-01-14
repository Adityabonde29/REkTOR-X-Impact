# REkTOR-X-Impact🚀
======================

Overview
--------

Welcome to the Donation Website! This platform bridges the gap between generous donors and organizations in need. Built with a powerful .NET backend and a sleek Angular frontend, our goal is to make the donation process seamless and transparent.

Features
--------

### 🎭 User Roles

-   Admin: The overseer who verifies organizations and manages the platform.
-   Organization: Posts requests for donations (clothes, food, funds, etc.).
-   User: Views donation requests and posts offers to donate.

### 🤝 Donation Interactions

-   Organizations: Post detailed donation requests.
-   Users: View and respond to requests or post their own donation offers.
-   Admin Dashboard: Manage users and organizations, approve registrations, and access detailed statistics.

Technology Stack
----------------

-   Backend:

    -   .NET Core
    -   ASP.NET Core MVC
    -   Entity Framework Core
    -   Identity for authentication and authorization
-   Frontend:

    -   Angular
    -   Angular Material for UI components
    -   RxJS for reactive programming

Installation
------------

### Backend

1.  Clone the repository:

    ```
    git clone https://github.com/adityabonde29/REkTOR-X-Impact.git
    cd donation-website/backend

    ```

2.  Restore dependencies:

    ```
    dotnet restore

    ```

3.  Update the database:

    ```
    dotnet ef database update

    ```

4.  Run the application:

    ```
    dotnet run

    ```

### Frontend

1.  Navigate to the frontend directory:

    ```
    cd ../frontend

    ```

2.  Install dependencies:

    ```
    npm install

    ```

3.  Run the application:

    ```
    ng serve

    ```

Usage
-----

1.  Register as a user or organization.
2.  Organizations can post donation requests.
3.  Users can view and respond to donation requests or post their own donation offers.
4.  Admins can manage users and organizations, and approve or reject organization registrations.

Contributing
------------

We welcome contributions! Please fork the repository and submit a pull request with your changes. Ensure your code follows the project's coding standards and includes appropriate tests.

License
-------

This project is licensed under the MIT License. See the LICENSE file for more details.

Contact
-------

For any questions or suggestions, please contact <aditya.bonde29@.com>.

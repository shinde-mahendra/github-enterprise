# Demo 1 : Working with Git Repositories

## Prerequisites

- Windows OS
- Internet connection

## Step 1: Install CMDER

1. Download CMDER from [https://cmder.net/](https://cmder.net/).
2. Extract the ZIP file to a preferred location (e.g., `C:\cmder`).
3. Launch `Cmder.exe`.

## Verify if GIT is Available in CMDer

1. In the CMDER terminal, type the following command and press Enter:

    ```
    git --version
    ```
2. If Git is installed, you will see the installed version number (e.g., `git version 2.45.1`). If not, you will receive an error message.

## Step 2: Configure Your Git User and Email

1. In the CMDER terminal, set your Git username by running:

    ```
    git config --global user.name "Your Name"
    ```

2. Set your Git email address:

    ```
    git config --global user.email "EMP_ID@hexaware.com"
    ```

3. Verify your configuration:

    ```
    git config --global --list
    ```

   You should see your username and email listed in the output.

## Step 3: Import a Repository Using GitHub Website

1. Go to [https://github.com/](https://github.com/) and sign in to your account.
2. Click the **+** icon in the top-right corner and select **Import repository**.
3. In the **Old repository’s clone URL** field, enter:

    ```
    https://github.com/octocat/Spoon-Knife
    ```
4. In the **Repository name** field, enter your desired repository name.
5. Ensure the **Public** option is selected.
6. Click **Begin import**.
7. Wait for the import to complete. Your new Private repository will be created with the contents of `Spoon-Knife`.

## Step 4: Generate a Classic Personal Access Token for "Spoon-Knife"

1. Go to [https://github.com/settings/tokens](https://github.com/settings/tokens).
2. Click **Generate new token** and select **Generate new token (classic)**.
3. Enter a descriptive **Note** (e.g., `Spoon-Knife Access`).
4. Set an **Expiration** date as needed.
5. Under **Select scopes**, check:
    - `repo` (Full control of private repositories)
6. Click **Generate token** at the bottom.
7. Copy the generated token and store it securely. You will use this token as your password when accessing the "Spoon-Knife" repository via Git.
8. Use "Windows Notepad" to keep Generated Token for later use.

## Step 5: Clone the New Repository and Make Changes

1. In the CMDER terminal, navigate to the directory where you want to clone the repository:

    ```
    mkdir \git-repos
    cd \git-repos
    ```

2. Clone your newly imported repository (replace `<your-username>` and `<repo-name>` with your GitHub username and repository name):

    ```
    git clone https://github.com/<your-username>/<repo-name>.git
    ```

    > You should get a small pop-up windows to choose credential manager, choose "wincred"
    > Enter your github username which should be like : `EMPID_hexaware`
    > Enter password : <Paste PAT created in Step#4>

3. Change into the cloned repository directory:

    ```
    cd <repo-name>
    ```

4. Create a new file or edit an existing file. For example, to create a `demo.txt` file:

    ```
    echo Hello, GitHub! > demo.txt
    ```

5. Add the changes to the staging area:

    ```
    git add .
    ```

6. Commit your changes with a message:

    ```
    git commit -m "Add demo.txt with greeting"
    ```

7. Push your changes to GitHub (you will be prompted for your username and the personal access token as the password):

    ```
    git push origin main
    ```

# Using an existing repository from GitHub Enterprise

## 1. Login into your GitHub

1. Go to [GitHub Login page](https://github.com/hexavarsity-mavericks/)
2. Login with your Hexaware Credentials
3. Find an existing Repository with name `EMP-ID_repo`
4. If you get `Quick Setup` page with TWO options
    i.  Create new repository on command line
    ii. Push an existing repository from the command line
5. Open GitHub in new tab
6. Use URL `https://github.com/settings/token`
7. Click on `Generate New Token` (Right top of screen)
8. Then click `Generate new token (classic)`
9. Enter name for Token (eg T1) and choose permissions: `Repo` and `Workflow`
10. Click `Generate` button, after token is generated, copy token text and store it in notepad for later use.
11. Click on name of token, then click `Configure SSO` -> choose Organization name `Hexavarsity-mavericks` and click `Authorize`
12. Go back to browser tab where `Quick setup` from repository is visible.
13. Copy the instructions for option 1 `Create new repository on command line`
14. Open `cmder.exe` or command prompt
15. Create new folder
    mkdir \repo1001
    cd \repo1001
16. Paste the commands you copied from Quick setup
17. At the last command `Git Push`, your terminal should prompt you to enter username and password
18. Enter your employee-id_hexaware and for password use the TOKEN generated earlier.
---

## 2. Clone the New Repository Locally Using Command Prompt

1. After the import completes, copy the URL of your new repository (e.g., `https://github.com/your-empid/new-repo.git`).
2. Open **Command Prompt**.
3. Run:
    
    ```sh
    git clone https://github.com/your-empid/new-repo.git
    ```
    > Replace with your actual repository URL.

---

**You have now imported and cloned the repository locally.**

## Create new Github Action workflow to build and publish container image to GitHub Container Registry

1. Navigate to your newly created (imported) repository
2. Go to the `Actions tab` in your GitHub repository.
3. Click **"New workflow"**.
4. Search for **"Publish Docker image"** in the available workflow templates.
5. Click **"Configure"** on the **Publish Docker image** template.
6. Review and update the workflow file as needed (e.g., set the correct image name and registry).
7. Click **"Start commit"** and then **"Commit new file"** to add the workflow to your repository.

> This workflow will automatically build and publish your Docker image to GitHub Container Registry on every push.


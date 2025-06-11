# Using an Existing Repository from GitHub Enterprise

## 1. Login to GitHub

1. Go to the https://github.com/hexavarsity-mavericks
2. Log in with your Hexaware credentials.
3. Find an existing repository named `EMP-ID_repo`.
4. If you see the `Quick Setup` page with two options:
    - **Create a new repository on the command line**
    - **Push an existing repository from the command line**
5. Open GitHub in a new tab.
6. Visit `https://github.com/settings/token`.
7. Click **Generate New Token** (top right of the screen).
8. Then click **Generate new token (classic)**.
9. Enter a name for the token (e.g., T1) and select permissions: `repo` and `workflow`.
10. Click **Generate**. After the token is generated, copy the token text and save it in Notepad for later use.
11. Click the name of the `token`
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

## 2. Add a project in this repository

1. Visit https://github.com/mahendra-shinde/asp.net-core-ci using web browser
2. Locate a green button `Code` click on it
3. Use option `Download as ZIP`
4. Go back to command prompt or Cmder where you have local repository accessible.
6. use command `pwd` to get local folder path, copy this path
7. Open the newly downloaded `asp.net-core-ci-master.zip` using file extraction tools like WinZip or 7Zip
8. Inside the ZIP file, there should be a folder, open the folder `asp.net-core-ci-master` and extract the contents of this folder
9. For extraction path (destination) use CTRL-V (paste) to use local path shown by `pwd` command in earlier step (6).
10. Click `Overwrite` if file confict occurrs.
11. go back to Cmder terminal and use following command to commit and push the changes
    ```
    git add .
    git commit -m "Project files added"
    git push
    ```

    > You should get a prompt for username and password, but if you didnt get any and PUSH was shown as sucessful. It means git is using `Credential Manager` to store and retrieve your password automatically.


## Create new Github Action workflow to build and publish container image to GitHub Container Registry

1. Navigate to your newly created (imported) repository
2. Go to the `Actions tab` in your GitHub repository.
3. Click **"New workflow"**.
4. Search for **"Publish Docker image"** in the available workflow templates.
5. Click **"Configure"** on the **Publish Docker image** template.
6. Review and update the workflow file as needed (e.g., set the correct image name and registry).
7. Click **"Start commit"** and then **"Commit new file"** to add the workflow to your repository.



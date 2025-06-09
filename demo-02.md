# Importing a GitHub Repository and Cloning Locally

## 1. Import the Repository on GitHub

1. Go to [GitHub Importer](https://github.com/new/import).
2. In **"Your old repository’s clone URL"**, enter:

    ```
    https://github.com/mahendra-shinde/asp.net-core-ci
    ```
3. Choose your **new repository name** and owner (DO NOT USE Organization !).
4. Click **"Begin import"**.

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


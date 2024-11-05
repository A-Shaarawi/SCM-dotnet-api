pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                script {
                    bat 'dotnet build SCM-dotnet-api.sln'
                }
            }
        }
        stage('Docker Build') {
            steps {
                script {
                    bat 'docker build -t your-api-image-name .'
                }
            }
        }
        stage('Deploy to Staging') {
            steps {
                script {
                    bat 'docker-compose up --build -d'
                }
            }
        }
    }
}

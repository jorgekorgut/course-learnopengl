#pragma once
#include "Shader.h"
#include "Mesh.h"
#include <string>
#include <vector>
#include <assimp/scene.h>

class Model
{
public:
    Model(std::string path)
    {
        loadModel(path);
    }

    void Draw(Shader& shader);
private:
    std::vector<Texture> textures_loaded;
    // model data
    std::vector<Mesh> meshes;
    std::string directory;

    void loadModel(std::string path);
    void processNode(aiNode* node, const aiScene* scene);
    Mesh processMesh(aiMesh* mesh, const aiScene* scene);
    std::vector<Texture> loadMaterialTextures(aiMaterial* mat, aiTextureType type, std::string typeName);
};
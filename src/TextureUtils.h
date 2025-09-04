#pragma once
#include <string>
#include <vector>

class TextureUtils {
public:
	static void setupTextureUtils();
	static unsigned int loadTexture(char const* file, const std::string directory);
	static unsigned int loadCubemap(std::vector<std::string> faces, const std::string directory);

};
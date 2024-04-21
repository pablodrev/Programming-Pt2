#include <iostream>
#include <vector>

const int MAX_COL = 5;
const int MIN_WEIGHT = -99999;

std::vector<std::string> read_input(int n) {
    std::vector<std::string> matrix(n);
    for (int i = 0; i < n; ++i) {
        std::cin >> matrix[i];
    }
    return matrix;
}

int find_max_path(int n, const std::vector<std::string>& matrix) {
    if (matrix[0] == "WWW") {
        return 0;
    }
    std::vector<std::vector<int>> game(n, std::vector<int>(MAX_COL, MIN_WEIGHT));
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < 3; ++j) {
            if (matrix[i][j] == 'W') {
                game[i][j + 1] = MIN_WEIGHT;
            }
            else if (matrix[i][j] == '.') {
                game[i][j + 1] = 0;
            }
            else if (matrix[i][j] == 'C') {
                game[i][j + 1] = 1;
            }
        }
    }
    for (int i = 1; i < n; ++i) {
        for (int j = 1; j < 4; ++j) {
            game[i][j] = game[i][j] + std::max(game[i - 1][j - 1], game[i - 1][j], game[i - 1][j + 1]);
        }
    }
    int max_val = game[n - 1][0];
    for (int i = 1; i < game[n - 1].size(); i++) {
        if (game[n - 1][i] > max_val) {
            max_val = game[n - 1][i];
        }
    }
    return max_val;
}

int main() {
    int n;
    std::cin >> n;
    std::vector<std::string> matrix = read_input(n);
    int result = find_max_path(n, matrix);
    if (result < 0) {
        std::cout << 0 << std::endl;
    }
    else {
        std::cout << result << std::endl;
    }
    return 0;
}
#include <iostream>
#include <vector>

using namespace std;

int main() {
    short n, m;
    cin >> n >> m;
    vector<vector<long long int>> matrix(n, vector<long long int>(m));
    vector<vector<long long int>> matrix_rot(m, vector<long long int>(n));

    for (short i = 0; i < n; i++) {
        for (short j = 0; j < m; j++) {
            cin >> matrix[i][j];
        }
    }

    for (short i = 0; i < m; i++) {
        for (short j = 0; j < n; j++) {
            matrix_rot[i][n - j - 1] = matrix[j][i];
        }
    }

    for (short i = 0; i < m; i++) {
        for (short j = 0; j < n; j++) {
            cout << matrix_rot[i][j] << " ";
        }
        cout << endl;
    }

    return 0;
}
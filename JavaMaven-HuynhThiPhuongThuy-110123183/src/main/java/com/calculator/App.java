package com.calculator;

public class App {
    
    // Hàm biện luận giải phương trình bậc 1: ax + b = 0
    public String giaiPhuongTrinhBac1(double a, double b) {
        if (a == 0) {
            if (b == 0) {
                return "VSN"; // Vô số nghiệm
            } else {
                return "VN";  // Vô nghiệm
            }
        } else {
            return "CN";      // Có nghiệm duy nhất
        }
    }

    public static void main(String[] args) {
        System.out.println("May tinh dang hoat dong!");
    }
}
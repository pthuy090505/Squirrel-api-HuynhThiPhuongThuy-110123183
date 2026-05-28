package com.calculator;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class AppTest {
    App app = new App();

    @Test // Trường hợp 1: Có nghiệm (a != 0)
    public void testCoNghiem() {
        assertEquals("CN", app.giaiPhuongTrinhBac1(2, 4));
    }

    @Test // Trường hợp 2: Vô số nghiệm (a = 0, b = 0)
    public void testVoSoNghiem() {
        assertEquals("VSN", app.giaiPhuongTrinhBac1(0, 0));
    }

    @Test // Trường hợp 3: Vô nghiệm (a = 0, b != 0)
    public void testVoNghiem() {
        assertEquals("VN", app.giaiPhuongTrinhBac1(0, 5));
    }
}
/* ===================
 * Orson Charts - Demo
 * ===================
 * 
 * Copyright (c) 2013-2016, Object Refinery Limited.
 * All rights reserved.
 *
 * http://www.object-refinery.com/orsoncharts/index.html
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *   - Redistributions of source code must retain the above copyright
 *     notice, this list of conditions and the following disclaimer.
 *   - Redistributions in binary form must reproduce the above copyright
 *     notice, this list of conditions and the following disclaimer in the
 *     documentation and/or other materials provided with the distribution.
 *   - Neither the name of the Object Refinery Limited nor the
 *     names of its contributors may be used to endorse or promote products
 *     derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
 * ARE DISCLAIMED. IN NO EVENT SHALL OBJECT REFINERY LIMITED BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * Note that the above terms apply to the demo source only, and not the 
 * Orson Charts library.
 * 
 */

package orsoncharts.demo.fx;

import static javafx.application.Application.launch;

import java.util.stream.Stream;

import javafx.application.Application;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;
import sun.security.mscapi.CPublicKey.CECPublicKey;

import com.orsoncharts.Chart3D;
import com.orsoncharts.data.PieDataset3D;
import com.orsoncharts.demo.PieChart3D2;
import com.orsoncharts.fx.Chart3DViewer;
import com.sun.javafx.binding.SelectBinding.AsString;

/**
 * A 3D pie chart demo for JavaFX.
 */
public class PieChart3DFXDemo3_Modified_Pan2040 extends Application {
	
	public static String[] categories;
	public static double[] values4Categories;
	static String title2Display=null;

    public static Node createDemoNode() {
        PieDataset3D<String> dataset = PieChart3D_Modified_Pan2040.createDataset(categories,values4Categories);
        Chart3D chart = PieChart3D2.createChart(dataset);
        Chart3DViewer viewer = new Chart3DViewer(chart);
        return viewer;
    }

    @Override
    public void start(Stage stage) throws Exception {
        StackPane sp = new StackPane();
        sp.getChildren().add(createDemoNode());
        Scene scene = new Scene(sp, 768, 512);
        stage.setScene(scene);
        stage.setTitle("Orson Charts: PieChart3DFXDemo2.java");
        stage.show();
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    	String[] categories_temp= {"A-Level","B-Level","C-Level","D'-Level"};
    	PieChart3DFXDemo3_Modified_Pan2040.categories=new String[categories_temp.length];
    	
    	PieChart3DFXDemo3_Modified_Pan2040.categories= Stream.of(categories_temp).toArray(String[]::new);
    	
    	PieChart3DFXDemo3_Modified_Pan2040.values4Categories=new double[categories.length];
    	PieChart3DFXDemo3_Modified_Pan2040.values4Categories[0]=30;
    	PieChart3DFXDemo3_Modified_Pan2040.values4Categories[1]=20;
    	PieChart3DFXDemo3_Modified_Pan2040.values4Categories[2]=10;
    	
    	PieChart3DFXDemo3_Modified_Pan2040.title2Display="Grade_Distribution";
        //launch(args);
//        Application.launch(args);
    	PieChart3D_Modified_Pan2040.launch(args);
    }
}

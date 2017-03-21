import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { AnalyticsComponent } from './components/analytics/analytics.component';

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        AnalyticsComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'analytics', pathMatch: 'full' },
            { path: 'analytics', component: AnalyticsComponent },
            { path: '**', redirectTo: 'analytics' }
        ])
    ]
})
export class AppModule {
}

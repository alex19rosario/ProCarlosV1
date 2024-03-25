import {
    Component,
    Injector,
    OnInit,
    Output,
    EventEmitter
} from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AppComponentBase } from '@shared/app-component-base';
import {
    CreateCollegeDto,
    CollegeServiceProxy
} from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: 'create-college-dialog.component.html'
})
export class CreateCollegeDialogComponent extends AppComponentBase
    implements OnInit {
    saving = false;
    college: CreateCollegeDto = new CreateCollegeDto();

    @Output() onSave = new EventEmitter<any>();

    constructor(
        injector: Injector,
        public _collegeService: CollegeServiceProxy,
        public bsModalRef: BsModalRef
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.college.isActive = true;
    }

    save(): void {
        this.saving = true;

        this._collegeService.create(this.college).subscribe(
            () => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.bsModalRef.hide();
                this.onSave.emit();
            },
            () => {
                this.saving = false;
            }
        );
    }
}
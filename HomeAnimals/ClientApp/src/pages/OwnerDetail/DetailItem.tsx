import * as React from "react";
interface IProps {
  label: string;
  value: any
}

export default class DetailItem extends React.Component<any, IProps> {

  render() {
    const { label, value } = this.props;
    return (
      <div className="d-flex flex-wrap block list-group-item">
        <div className="w-25">
          <h6 className="mb-0">{label}: </h6>
        </div>
        <p className="mb-0">{value}</p>
      </div>
    );
  }
}